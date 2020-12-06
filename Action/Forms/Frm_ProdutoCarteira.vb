Imports Action.Classes
Imports Action.Controller

Public Class Frm_ProdutoCarteira
    Dim objCarteira As New ControladorCarteira
    Dim objControlRendaFixa As New ControladorRendaFixa
    Dim objAcao As New ControladorAcao
    Dim objFundoImobiliario As New ControladorFundoImobiliario
    Dim objInvestimento As New Investimento
    Dim objRendaFixa As New RendaFixa
    Dim objUsuarioLogado As New Usuario
    Dim dtCarteira As New DataTable
    Dim dtAcoes As New DataTable
    Dim dtFundoImobiliario As New DataTable
    Dim dtRendaFixa As New DataTable
    Dim dtUsuario As New DataTable
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Adicionar"
        CarregaComboCarteira()
        CarregaComboTipoAtivo()


    End Sub

    'CARREGA AS INFORMAÇÕES DO COMBOBOX REFERENTE A CARTEIRA
    Private Sub CarregaComboCarteira()
        'EXTRAI AS INFORMAÇÕES DO USUARIO LOGADO ATRAVÉS DA FUNÇÃO GETUSUARIOLOGADO
        objUsuarioLogado.Usuario = GetUsuarioLogado()

        'POPULA O OBJETO USUARIOLOGADO
        SetObjetoUsuarioLogado(objUsuarioLogado)

        dtCarteira = objCarteira.ConsultarCarteira
        Cmb_NomeCarteira.Items.Add("<Selecione>")

        For Each linha As DataRow In dtCarteira.Rows

            If objUsuarioLogado.Usuario = linha(11) Then
                Dim lista As New ListViewItem
                lista.Text = linha("NomeCarteira").ToString()
                lista.SubItems.Add(linha("NomeCarteira").ToString())
                Cmb_NomeCarteira.Items.Add(lista.Text)

            End If
        Next



        Cmb_NomeCarteira.SelectedIndex = 0

    End Sub



    'CARREGA AS INFORMAÇÕES DO COMBOBOX REFERENTE AO TIPO DE ATIVO(AÇÃO, RENDA FIXA...)
    Private Sub CarregaComboTipoAtivo()

        Dim tipoAtivo As New List(Of String)
        tipoAtivo.Add("<Selecione>")
        tipoAtivo.Add("Renda Fixa")
        tipoAtivo.Add("Ações")
        tipoAtivo.Add("Fundo imobiliario")

        For Each item In tipoAtivo
            Cmb_TipoAtivo.Items.Add(item)
        Next

        Cmb_TipoAtivo.SelectedIndex = 0

    End Sub

    'CARREGA AS INFORMAÇÕES SOBRE O O QUE SERÁ INSERIDO DE ACORDO COM O TIPOATIVO

    Private Sub CarregaComboAtivo()

        Cmb_Ativo.Items.Add("<Selecione>")
        Cmb_Ativo.SelectedIndex = 0

    End Sub

    Private Sub Cmb_TipoAtivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_TipoAtivo.SelectedIndexChanged




        If Cmb_TipoAtivo.SelectedIndex = 1 Then
            Cmb_Ativo.Items.Clear()
            CarregaComboAtivo()
            Cmb_Ativo.SelectedIndex = 0
            dtRendaFixa = objControlRendaFixa.ConsultarRendaFixa

            For i As Integer = 0 To dtRendaFixa.Rows.Count - 1
                Cmb_Ativo.Items().Add(dtRendaFixa.Rows(i)("Sigla"))

            Next

        ElseIf Cmb_TipoAtivo.SelectedIndex = 2 Then
            Cmb_Ativo.Items.Clear()
            CarregaComboAtivo()
            Cmb_Ativo.SelectedIndex = 0
            dtAcoes = objAcao.ConsultarAcao

            For i As Integer = 0 To dtAcoes.Rows.Count - 1
                Cmb_Ativo.Items().Add(dtAcoes.Rows(i)("SiglaAtivo"))
            Next
            Cmb_Ativo.SelectedIndex = 0

        ElseIf Cmb_TipoAtivo.SelectedIndex = 3 Then

            Cmb_Ativo.Items.Clear()
            CarregaComboAtivo()
            Cmb_Ativo.SelectedIndex = 0

            dtFundoImobiliario = objFundoImobiliario.ConsultarFundoImobiliario

            For i As Integer = 0 To dtFundoImobiliario.Rows.Count - 1
                Cmb_Ativo.Items().Add(dtFundoImobiliario.Rows(i)("SiglaAtivo"))
            Next
        Else
            Cmb_Ativo.Items.Clear()
            CarregaComboAtivo()
            Cmb_Ativo.SelectedIndex = 0
        End If

    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click

        Try
            Dim v1 As Double = txt_preco.Text
            Dim v2 As Double = Txt_quantidade.Text
            Dim v3 As Double

            v3 = v1 * v2

            Txt_TotalAplicado.Text = v3.ToString
            If ValidaCampos() = True Then


                objInvestimento.NomeAtivo = Txt_descricao.Text
                objInvestimento.SiglaAtivo = Cmb_Ativo.SelectedItem
                objInvestimento.PrecoAtivo = txt_preco.Text
                objInvestimento.Quantidade = Txt_quantidade.Text
                objInvestimento.PrecoMedio = Txt_TotalAplicado.Text / Txt_quantidade.Text
                objInvestimento.DataTransacao = Now
                objInvestimento.IdCarteira = Cmb_NomeCarteira.SelectedIndex
                objInvestimento.IdTipoAtivo = Cmb_TipoAtivo.SelectedIndex
                ControladorInvestimento.InsereInvestimento(objInvestimento)
                MessageBox.Show("Ativo adicionado com sucesso.")


            Else
                MessageBox.Show("Preencha todas as informações para inserir o cadastro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub

    'FUNÇÃO PRIVADA PARA VALIDAR SE TODOS OS CAMPOS FORAM PREENCHIDOS

    Private Function ValidaCampos() As Boolean

        Try
            Dim vRetorno As Boolean
            If Cmb_Ativo.SelectedIndex = 0 Or Cmb_NomeCarteira.SelectedIndex = 0 Or Cmb_Ativo.SelectedIndex = 0 Or String.IsNullOrEmpty(txt_preco.Text) = True _
                Or String.IsNullOrEmpty(Txt_quantidade.Text) Then
                vRetorno = False

            Else
                vRetorno = True
            End If
            Return vRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Private Sub Txt_TotalAplicado_TextChanged(sender As Object, e As EventArgs) Handles Txt_TotalAplicado.TextChanged
        Txt_TotalAplicado.Text = Val(txt_preco.Text.ToString) * Val(Txt_quantidade.Text.ToString)
    End Sub



    'Private Sub SetObjRendaFixa()

    '    objRendaFixa.
    'End Sub

    Private Function GetUsuarioLogado() As String

        Dim usuariologado As String = Frm_Principal.Tsl_UsuarioLogado.Text
        Dim indice1 As Integer = usuariologado.IndexOf(":")
        Dim NovoUsuarioLogado As String = usuariologado.Substring(indice1 + 2)

        Return NovoUsuarioLogado

    End Function

    Private Function SetObjetoUsuarioLogado(objUsuarioLogado As Usuario) As Usuario
        Dim controlUsuario As New ControladorUsuario
        dtUsuario = controlUsuario.ConsultarUsuarioLogado(objUsuarioLogado)
        objUsuarioLogado.Id = dtUsuario.Rows(0).Item(0)
        objUsuarioLogado.Nome = dtUsuario.Rows(0).Item(1)
        objUsuarioLogado.Usuario = dtUsuario.Rows(0).Item(2)
        objUsuarioLogado.Senha = dtUsuario.Rows(0).Item(3)
        objUsuarioLogado.DataCadastro = dtUsuario.Rows(0).Item(4)
        objUsuarioLogado.Permissao = dtUsuario.Rows(0).Item(5)

        Return objUsuarioLogado
    End Function
End Class