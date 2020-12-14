Imports Action.Classes
Imports Action.Controller

Public Class Frm_GerenciarProduto
    Dim controladorInvestimento As New ControladorInvestimento
    Dim dtConsultaRegistroInvestimentos As New DataTable
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Gerenciar Produtos"
        ConfigurarGrid()
        PreencheComboBoxFiltro()
        PreencheComboboxTipoAtivo()
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        DateTimePicker1.Value = Date.Today
    End Sub



    Private Sub ConfigurarGrid()

        With Dgw_Ativos


            ' POPULANDO O GRID COM INFORMAÇÕES DO BD
            dtConsultaRegistroInvestimentos = controladorInvestimento.ConsultaInvestimentos(ObjAtributos.AtbId)
            Dgw_Ativos.DataSource = dtConsultaRegistroInvestimentos

            'COLUNAS QUE NÃO IRÃO SER EXIBIDAS
            .Columns(0).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False

            'CABEÇALHOS DAS COLUNAS
            .Columns("PrecoTotal").HeaderText = "Valor total aplicado"
            .Columns("NomeAtivo").HeaderText = "Instituição Financeira"
            .Columns("PrecoAtivo").HeaderText = "Preco da ultima compra"
            .Columns("NomeCarteira").HeaderText = "Carteira"
            .Columns("SiglaATivo").HeaderText = "Ativo"
            .Columns("IdAtivo").HeaderText = "Codigo Ativo"
            .Columns("TipoAtivo").HeaderText = "Tipo Ativo"


            'FORMTAÇÃO DA CELULA PARA RECEBER MOEDA
            .Columns("PrecoAtivo").DefaultCellStyle.Format = "C2"
            .Columns("PrecoTotal").DefaultCellStyle.Format = "C2"
            .Columns("TipoAtivo").HeaderText = "Tipo Ativo"


            'POSICIONAMENTO MANUAIS DAS COLUNAS
            .Columns("NomeCarteira").DisplayIndex = 1
            .Columns("TipoAtivo").DisplayIndex = 2

            'CELULAS QUE NÃO PODERAM SER ALTERADAS
            .Columns("TipoAtivo").ReadOnly = True
            .Columns("NomeCarteira").ReadOnly = True
            .Columns("SiglaATivo").ReadOnly = True
            .Columns("IdAtivo").ReadOnly = True





        End With



    End Sub

    'AÇÃO DE CHAMAR A TELA DE COMPRA DE ATIVOS DENTRO DO FORM DE GERENCIAR PRODUTO
    Private Sub Btn_ComprarAtivo_Click(sender As Object, e As EventArgs) Handles Btn_ComprarAtivo.Click
        'CHAMADA DO FORM DE COMPRA
        Try
            Dim f As New Frm_ProdutoCarteira
            f.ShowDialog()
            ConfigurarGrid()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Private Sub Btn_AlterarAtivo_Click(sender As Object, e As EventArgs) Handles Btn_AlterarAtivo.Click

        Try
            'CHAMADA DOS OBJETOS NECESSARIOS PARA ALTERAÇÃO
            Dim objInvestimento As New Investimento
            Dim controladorInvestimento As New ControladorInvestimento

            'PECORRE TODA AS LINHAS DO GRID GRAVANDO AS NOVAS INFORMAÇÕES QUE FORAM ALTERADAS.
            For i As Integer = 0 To Dgw_Ativos.Rows.Count - 1
                objInvestimento.Id = Dgw_Ativos.Rows(i).Cells("Id").Value
                objInvestimento.NomeAtivo = Dgw_Ativos.Rows(i).Cells("NomeAtivo").Value
                objInvestimento.SiglaAtivo = Dgw_Ativos.Rows(i).Cells("SiglaAtivo").Value
                objInvestimento.IdAtivo = Dgw_Ativos.Rows(i).Cells("IdAtivo").Value
                objInvestimento.PrecoAtivo = Dgw_Ativos.Rows(i).Cells("PrecoAtivo").Value
                objInvestimento.Quantidade = Dgw_Ativos.Rows(i).Cells("Quantidade").Value
                objInvestimento.PrecoTotal = Dgw_Ativos.Rows(i).Cells("PrecoAtivo").Value * Dgw_Ativos.Rows(i).Cells("Quantidade").Value
                objInvestimento.IdCarteira = Dgw_Ativos.Rows(i).Cells("IdCarteira").Value
                objInvestimento.IdTipoAtivo = Dgw_Ativos.Rows(i).Cells("IdTipoAtivo").Value
                controladorInvestimento.AlteraInvestimento(objInvestimento)
            Next
            MessageBox.Show("Alteração efetuada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ConfigurarGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PreencheComboBoxFiltro()
        Try
            'CRIA A LISTA COM AS OPÇÕES QUE ESTARÃO DISPONIVEL NO COMBOBOX
            Dim lista As New List(Of String)
            lista.Add("<Selecione>")
            lista.Add("Data")
            lista.Add("Nome da carteira")
            lista.Add("Sigla Ativo")
            lista.Add("Instituição Financeira")
            lista.Add("Tipo Ativo")


            'PECORRE A LISTA CRIADA E ADICIONA OS VALORES AO COMBOBOX
            For i As Integer = 0 To lista.Count - 1
                Cmb_Filtro.Items.Add(lista(i))
            Next

            'DEFINE COMO O COMBOBOX SERÁ INICIADO
            Cmb_Filtro.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try





    End Sub

    Private Sub Cmb_Filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Filtro.SelectedIndexChanged
        'ATRIBUI OS CAMPOS QUE SERÃO EXIBIDOS AO USUARIO DE ACORDO COM A OPÇÃO SELECIONADA
        Try
            If Cmb_Filtro.SelectedIndex = 0 Then

                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
                Txt_Busca.Visible = False
                Lbl_a.Visible = False
                Cmb_TipoAtivo.Visible = False

            ElseIf Cmb_Filtro.SelectedIndex = 1 Then

                DateTimePicker1.Visible = True
                DateTimePicker2.Visible = True
                Lbl_a.Visible = True
                Txt_Busca.Width = 0
                Cmb_TipoAtivo.Visible = False

            ElseIf Cmb_Filtro.SelectedIndex = 2 Then

                Txt_Busca.Visible = True
                Txt_Busca.Width = 200
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
                Lbl_a.Visible = False
                Cmb_TipoAtivo.Visible = False


            ElseIf Cmb_Filtro.SelectedIndex = 3 Then
                Txt_Busca.Visible = True
                Txt_Busca.Width = 200
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
                Lbl_a.Visible = False
                Cmb_TipoAtivo.Visible = False

            ElseIf Cmb_Filtro.SelectedIndex = 4 Then
                Txt_Busca.Visible = True
                Txt_Busca.Width = 200
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
                Lbl_a.Visible = False
                Cmb_TipoAtivo.Visible = False
            Else
                Cmb_TipoAtivo.Visible = True
                Cmb_TipoAtivo.Width = 150
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
                Lbl_a.Visible = False
                Txt_Busca.Visible = False

            End If
        Catch ex As Exception
            Throw ex
        End Try



    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click

        'AÇÕES DE BUSCA DE ACORDO COM CADA ITEM NO COMBOBOX
        Try
            'BUSCA POR DATA
            If Cmb_Filtro.SelectedItem = "Data" Then
                Dim dataInicial As Date = DateTimePicker1.Value
                Dim dataFinal As DateTime = DateTimePicker2.Value

                Dgw_Ativos.DataSource = BuscaInvestimentoData(ObjAtributos.AtbId, dataInicial, dataFinal)

                ' BUSCA POR NOME DA CARTEIRA
            ElseIf Cmb_Filtro.SelectedItem = "Nome da carteira" Then

                Dgw_Ativos.DataSource = BuscaInvestimentoNomeCarteira(ObjAtributos.AtbId, Txt_Busca.Text)

                'BUSCA POR NOME DO ATIVO
            ElseIf Cmb_Filtro.SelectedItem = "Sigla Ativo" Then

                Dgw_Ativos.DataSource = BuscaInvestimentoSiglaAtivo(ObjAtributos.AtbId, Txt_Busca.Text)

                'BUSCA POR NOME DA INSTITUIÇÃO FINANCEIRA INFORMADA
            ElseIf Cmb_Filtro.SelectedItem = "Instituição Financeira" Then

                Dgw_Ativos.DataSource = BuscaInvestimentoInstFinanceira(ObjAtributos.AtbId, Txt_Busca.Text)

                ' BUSCA POR TIPO ATIVO
            ElseIf Cmb_Filtro.SelectedItem = "Tipo Ativo" Then

                Dgw_Ativos.DataSource = BuscaInvestimentoIdTipoAtivo(ObjAtributos.AtbId, Cmb_TipoAtivo.SelectedIndex)

            Else
                ConfigurarGrid()
            End If

        Catch ex As Exception
            Throw ex
        End Try



    End Sub

    Private Sub PreencheComboboxTipoAtivo()
        'ADIÇÃO DAS INFORMAÇÕES DO COMBOBOX TIPO ATIVO DE FORMA MANUAL
        Try
            Dim lista As New List(Of String)
            lista.Add("<Selecione>")
            lista.Add("RendaFixa")
            lista.Add("Ação")
            lista.Add("Fundo imobiliario")

            For i As Integer = 0 To lista.Count - 1
                Cmb_TipoAtivo.Items.Add(lista(i))
            Next

            Cmb_TipoAtivo.SelectedIndex = 0
        Catch ex As Exception

            Throw ex
        End Try


    End Sub





    'FUNÇÃO DE BUSCA OS INVESTIMENTOS ATRAVÉS DE DATA 
    Private Function BuscaInvestimentoData(iOperador As Integer, dataInicial As DateTime, dataFinal As DateTime) As DataTable

        Try
            Dim dtFiltro As New DataTable
            Dim controladorInvestimento As New ControladorInvestimento

            dtFiltro = controladorInvestimento.PesquisaInvestimentoPorFiltroData(iOperador, dataInicial, dataFinal)

            Return dtFiltro

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'FUNÇAO DE BUSCA OS INVESTIMENTOS ATRAVÉS DO NOME DA CARTEIRA
    Private Function BuscaInvestimentoNomeCarteira(iOperador As Integer, nomeCarteira As String) As DataTable

        Try
            Dim dtFiltro As New DataTable
            Dim controladorInvestimento As New ControladorInvestimento

            dtFiltro = controladorInvestimento.BuscaInvestimentoNomeCarteira(iOperador, nomeCarteira)

            Return dtFiltro
        Catch ex As Exception

            Throw ex

        End Try



    End Function

    'FUNÇÃO DE BUSCA OS INVESTIMENTOS ATRAVÉS DA SIGLA ATIVO
    Private Function BuscaInvestimentoSiglaAtivo(iOperador As Integer, siglaAtivo As String) As DataTable

        Try
            Dim dtFiltro As New DataTable
            Dim controladorInvestimento As New ControladorInvestimento

            dtFiltro = controladorInvestimento.BuscaInvestimentoSiglaAtivo(iOperador, siglaAtivo)

            Return dtFiltro
        Catch ex As Exception

            Throw ex

        End Try


    End Function

    'FUNÇÃO DE BUSCA OS INVESTIMENTOS ATRAVÉS DA INSTFINANCEIRA
    Private Function BuscaInvestimentoInstFinanceira(iOperador As Integer, instFinanceira As String) As DataTable

        Try

            Dim controladorInvestimento As New ControladorInvestimento

            Return controladorInvestimento.BuscaInvestimentoInstFinanceira(iOperador, instFinanceira)
        Catch ex As Exception

            Throw ex
        End Try




    End Function

    'FUNÇÃO DE BUSCA OS INVESTIMENTOS ATRAVÉS DO TIPO ATIVO
    Private Function BuscaInvestimentoIdTipoAtivo(iOperador As Integer, idTipoAtivo As Integer) As DataTable

        Try
            Dim dtFiltro As New DataTable
            Dim controladorInvestimento As New ControladorInvestimento

            dtFiltro = controladorInvestimento.BuscaInvestimentoTipoAtivo(iOperador, idTipoAtivo)

            Return dtFiltro
        Catch ex As Exception

            Throw ex
        End Try


    End Function

    Private Sub Btn_VenderAtivo_Click(sender As Object, e As EventArgs) Handles Btn_VenderAtivo.Click
        Try

            Dim venderAtivo As New Frm_VenderAtivo
            venderAtivo.IdAtivo = Dgw_Ativos.SelectedRows(0).Cells("ID").Value
            venderAtivo.Txt_Ativo.Text = Dgw_Ativos.SelectedRows(0).Cells("SiglaAtivo").Value
            venderAtivo.Txt_QuantidadeDisponivel.Text = Dgw_Ativos.SelectedRows(0).Cells("Quantidade").Value
            venderAtivo.Txt_PosicaoAtual.Text = Dgw_Ativos.SelectedRows(0).Cells("PrecoTotal").Value
            venderAtivo.ShowDialog()
            ConfigurarGrid()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class