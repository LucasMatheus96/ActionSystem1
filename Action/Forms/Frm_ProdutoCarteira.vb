Imports Action.Classes
Imports Action.Controller

Public Class Frm_ProdutoCarteira
    Dim controladorCarteira As New ControladorCarteira
    Dim controladorRendaFixa As New ControladorRendaFixa
    Dim controladorAcao As New ControladorAcao
    Dim controladorFundoImobiliario As New ControladorFundoImobiliario
    Dim controladorInvestimentos As New ControladorInvestimento
    Dim objInvestimento As New Investimento
    Dim objRendaFixa As New RendaFixa
    Dim objUsuarioLogado As New Usuario
    Dim dtCarteira As New DataTable
    Dim dtAcoes As New DataTable
    Dim dtFundoImobiliario As New DataTable
    Dim dtRendaFixa As New DataTable
    Dim dtUsuario As New DataTable
    Dim dtInvestimento As New DataTable
    Dim indice As Integer = 0
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Adicionar"
        Txt_TotalAplicado.ReadOnly = True


        CarregaComboCarteira()
        CarregaComboTipoAtivo()
        ConfiguracaoDataGridViwer()




    End Sub

    'CARREGA AS INFORMAÇÕES DO COMBOBOX REFERENTE A CARTEIRA
    Private Sub CarregaComboCarteira()

        Try
            Cmb_Ativo.DataSource = Nothing
            dtCarteira = controladorCarteira.FiltrarCarteiraPorOperadorLogado(ObjAtributos.AtbId)


            For Each linha As DataRow In dtCarteira.Rows
                If ObjAtributos.AtbId = linha("IOperador") Then

                    With Cmb_NomeCarteira

                        .SelectionStart = 1

                        .DataSource = dtCarteira

                        .DisplayMember = "NomeCarteira"

                        .ValueMember = "Id"




                    End With

                End If

            Next
            Cmb_NomeCarteira.Text = "<Selecione>"


        Catch ex As Exception

            Throw ex
        End Try





    End Sub



    'CARREGA AS INFORMAÇÕES DO COMBOBOX REFERENTE AO TIPO DE ATIVO(AÇÃO, RENDA FIXA...)
    Private Sub CarregaComboTipoAtivo()
        Cmb_Ativo.DataSource = Nothing

        Dim tipoAtivo As New List(Of String)
        tipoAtivo.Add("<Selecione>")
        tipoAtivo.Add("Renda Fixa")
        tipoAtivo.Add("Ações")
        tipoAtivo.Add("Fundo imobiliario")

        For Each item In tipoAtivo
            With Cmb_TipoAtivo

                .DataSource = tipoAtivo

                .DisplayMember = tipoAtivo.Item(0)

            End With

        Next




    End Sub

    'CARREGA AS INFORMAÇÕES SOBRE O O QUE SERÁ INSERIDO DE ACORDO COM O TIPOATIVO



    Private Sub Cmb_TipoAtivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_TipoAtivo.SelectedIndexChanged




        If Cmb_TipoAtivo.SelectedIndex = 1 Then
            Cmb_Ativo.DataSource = Nothing


            dtRendaFixa = controladorRendaFixa.ConsultarRendaFixa

            For i As Integer = 0 To dtRendaFixa.Rows.Count - 1
                'Cmb_Ativo.Items().Add(dtRendaFixa.Rows(i)("Sigla"))
                With Cmb_Ativo

                    .DataSource = dtRendaFixa

                    .DisplayMember = "Sigla"

                    .ValueMember = "Id"


                    '.SelectedIndex = -1
                End With


            Next
            Cmb_Ativo.Text = "<Selecione>"


        ElseIf Cmb_TipoAtivo.SelectedIndex = 2 Then
            Cmb_Ativo.DataSource = Nothing
            dtAcoes = controladorAcao.ConsultarAcao

            For i As Integer = 0 To dtAcoes.Rows.Count - 1
                'Cmb_Ativo.Items().Add(dtAcoes.Rows(i)("SiglaAtivo"))

                With Cmb_Ativo

                    .DataSource = dtAcoes

                    .DisplayMember = "SiglaAtivo"

                    .ValueMember = "Id"

                End With
            Next
            Cmb_Ativo.Text = "<Selecione>"

        ElseIf Cmb_TipoAtivo.SelectedIndex = 3 Then

            Cmb_Ativo.DataSource = Nothing
            dtFundoImobiliario = controladorFundoImobiliario.ConsultarFundoImobiliario

            For i As Integer = 0 To dtFundoImobiliario.Rows.Count - 1
                With Cmb_Ativo

                    .DataSource = dtFundoImobiliario

                    .DisplayMember = "SiglaAtivo"

                    .ValueMember = "Id"

                End With
            Next
            Cmb_Ativo.Text = "<Selecione>"
        Else

            Cmb_Ativo.Text = "<Selecione>"
        End If

    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click

        Try


            If ValidaCampos() = True Then




                PopularGrid()

                If Btn_Adicionar.Text = "Alterar" Then

                    MessageBox.Show("Ativo alterado com sucesso.", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ativo adicionado com sucesso.", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
            Else
                MessageBox.Show("Preencha todas as informações para inserir o cadastro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub

    'FUNÇÃO PRIVADA PARA VALIDAR SE TODOS OS CAMPOS FORAM PREENCHIDOS

    Private Function ValidaCampos() As Boolean

        Try
            Dim vRetorno As Boolean
            If Cmb_Ativo.SelectedIndex >= 0 And Cmb_NomeCarteira.SelectedIndex >= 0 And Cmb_TipoAtivo.SelectedIndex >= 0 And String.IsNullOrEmpty(txt_preco.Text) = False _
                And String.IsNullOrEmpty(Txt_quantidade.Text) = False And String.IsNullOrEmpty(Txt_descricao.Text) = False Then
                vRetorno = True

            Else
                vRetorno = False
            End If
            Return vRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function





    'Private Sub SetObjRendaFixa()

    '    objRendaFixa.
    'End Sub


    Private Sub TotalInvestido()

        Try
            Dim precoAtivo As Double = txt_preco.Text
            Dim quantidade As Double = Txt_quantidade.Text
            Dim totalInvestido As Double = 0


            totalInvestido = precoAtivo * quantidade
            Txt_TotalAplicado.Text = totalInvestido.ToString("C2")

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub ConfiguracaoDataGridViwer()


        With DataGridView1
            Try
                'CRIAÇÃO DAS COLUNAS DENTRO DO DATA GRID VIEW
                .Columns.Add("Id", "IdCarteira")                                  '0
                .Columns.Add("Instituicao", "Instituição Financeira")     '1 
                .Columns.Add("NomeCarteira", "Carteira")                  '2
                .Columns.Add("TipoAtivo", "Tipo Ativo")                   '3
                .Columns.Add("Ativo", "Ativo")                            '4
                .Columns.Add("Preco", "Preço unidade")                    '5
                .Columns.Add("Quantidade", "Qtd")                         '6 
                .Columns.Add("Total", "Valor Total")                      '7
                .Columns.Add("IdAtivo", "Codigo do ativo")

                '
                .Columns(0).Width = 50
                .Columns(1).Width = 200
                .Columns(2).Width = 150
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                .Columns(5).Width = 50
                .Columns(6).Width = 30
                .Columns(7).Width = 100
                .Columns(8).Width = 50




            Catch ex As Exception
                Throw ex
            End Try

        End With



    End Sub

    Private Sub PopularGrid()

        'Valida se o grid possui linhas 
        If DataGridView1.SelectedRows.Count > 0 Then


            ' traz informação do indice da linha selecionada
            indice = DataGridView1.SelectedRows(0).Index

            'Aualiza as informações da linha do grid após alterações
            DataGridView1.Rows(indice).Cells(0).Value = Cmb_NomeCarteira.SelectedValue
            DataGridView1.Rows(indice).Cells(1).Value = Txt_descricao.Text
            DataGridView1.Rows(indice).Cells(2).Value = Cmb_NomeCarteira.SelectedItem("NomeCarteira")
            DataGridView1.Rows(indice).Cells(3).Value = Cmb_TipoAtivo.SelectedIndex
            DataGridView1.Rows(indice).Cells(4).Value = Cmb_Ativo.Text
            DataGridView1.Rows(indice).Cells(5).Value = Double.Parse(txt_preco.Text).ToString("C2")
            DataGridView1.Rows(indice).Cells(6).Value = Txt_quantidade.Text
            DataGridView1.Rows(indice).Cells(7).Value = Double.Parse(Txt_TotalAplicado.Text)
            DataGridView1.Rows(indice).Cells(8).Value = Cmb_Ativo.SelectedValue


        Else
            'Insere os dados no grid
            DataGridView1.Rows.Add(Cmb_NomeCarteira.SelectedValue, Txt_descricao.Text, Cmb_NomeCarteira.SelectedItem("NomeCarteira"), Cmb_TipoAtivo.SelectedIndex,
                                   Cmb_Ativo.Text, txt_preco.Text, Txt_quantidade.Text, Txt_TotalAplicado.Text, Cmb_Ativo.SelectedValue)
            DataGridView1.ClearSelection()
        End If





    End Sub

    Private Sub Btn_Confirmar_Click(sender As Object, e As EventArgs) Handles Btn_Confirmar.Click

        Try

            dtInvestimento = controladorInvestimentos.ConsultaInvestimentos(ObjAtributos.AtbId)

            If dtInvestimento.Rows.Count < 1 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    objInvestimento.NomeAtivo = DataGridView1.Rows(i).Cells(1).Value
                    objInvestimento.SiglaAtivo = DataGridView1.Rows(i).Cells(4).Value
                    objInvestimento.IdAtivo = DataGridView1.Rows(i).Cells(8).Value
                    objInvestimento.PrecoAtivo = DataGridView1.Rows(i).Cells(5).Value
                    objInvestimento.Quantidade = DataGridView1.Rows(i).Cells(6).Value
                    objInvestimento.PrecoTotal = DataGridView1.Rows(i).Cells(7).Value
                    objInvestimento.DataTransacao = Now
                    objInvestimento.IdCarteira = DataGridView1.Rows(i).Cells(0).Value
                    objInvestimento.IdTipoAtivo = DataGridView1.Rows(i).Cells(3).Value
                    controladorInvestimentos.InsereInvestimento(objInvestimento)
                Next


            ElseIf dtInvestimento.Rows.Count >= 1 Then
                For j As Integer = 0 To dtInvestimento.Rows.Count - 1
                    If dtInvestimento.Rows(j)("SiglaAtivo") = Cmb_Ativo.Text Then
                        For i As Integer = 0 To DataGridView1.Rows.Count - 1

                            objInvestimento.Id = dtInvestimento.Rows(j)("ID")
                            objInvestimento.PrecoAtivo = dtInvestimento.Rows(j)("PrecoAtivo")
                            objInvestimento.Quantidade = dtInvestimento.Rows(j)("Quantidade")
                            objInvestimento.PrecoTotal = dtInvestimento.Rows(j)("PrecoTotal")


                            objInvestimento.NomeAtivo = DataGridView1.Rows(i).Cells(1).Value
                            objInvestimento.SiglaAtivo = DataGridView1.Rows(i).Cells(4).Value
                            objInvestimento.IdAtivo = DataGridView1.Rows(i).Cells(8).Value
                            objInvestimento.PrecoAtivo = DataGridView1.Rows(i).Cells(5).Value
                            objInvestimento.Quantidade += DataGridView1.Rows(i).Cells(6).Value
                            objInvestimento.PrecoTotal += DataGridView1.Rows(i).Cells(7).Value
                            objInvestimento.DataTransacao = Now
                            objInvestimento.IdCarteira = DataGridView1.Rows(i).Cells(0).Value
                            objInvestimento.IdTipoAtivo = DataGridView1.Rows(i).Cells(3).Value
                            controladorInvestimentos.AlteraInvestimento(objInvestimento)
                        Next
                        MessageBox.Show("Ativo adicionado com sucesso.", "Cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DataGridView1.Rows.Clear()
                        Btn_Adicionar.Text = "Adicionar"

                    End If


                Next

                If DataGridView1.Rows.Count >= 1 Then

                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        objInvestimento.NomeAtivo = DataGridView1.Rows(i).Cells(1).Value
                        objInvestimento.SiglaAtivo = DataGridView1.Rows(i).Cells(4).Value
                        objInvestimento.IdAtivo = DataGridView1.Rows(i).Cells(8).Value
                        objInvestimento.PrecoAtivo = DataGridView1.Rows(i).Cells(5).Value
                        objInvestimento.Quantidade = DataGridView1.Rows(i).Cells(6).Value
                        objInvestimento.PrecoTotal = DataGridView1.Rows(i).Cells(7).Value
                        objInvestimento.DataTransacao = Now
                        objInvestimento.IdCarteira = DataGridView1.Rows(i).Cells(0).Value
                        objInvestimento.IdTipoAtivo = DataGridView1.Rows(i).Cells(3).Value
                        controladorInvestimentos.InsereInvestimento(objInvestimento)
                    Next
                    MessageBox.Show("Ativo adicionado com sucesso.", "Cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.Rows.Clear()
                    Btn_Adicionar.Text = "Adicionar"

                End If

            End If



        Catch ex As Exception
            Throw ex
            'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub

    Private Sub Frm_ProdutoCarteira_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If DataGridView1.Rows.Count >= 1 Then
            DialogResult = MessageBox.Show("Deseja realmente sair? os itens informados não serão salvos", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If DialogResult = DialogResult.Yes Then
                Me.Dispose()
                Me.Close()
            Else DialogResult = DialogResult.No
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                indice = DataGridView1.SelectedRows(0).Index
                Btn_Adicionar.Text = "Alterar"
                Txt_descricao.Text = DataGridView1.Rows(indice).Cells(1).Value
                Cmb_TipoAtivo.SelectedIndex = DataGridView1.Rows(indice).Cells(3).Value
                objInvestimento.SiglaAtivo = DataGridView1.Rows(indice).Cells(4).Value
                Cmb_Ativo.SelectedValue = DataGridView1.Rows(indice).Cells(8).Value
                txt_preco.Text = DataGridView1.Rows(indice).Cells(5).Value
                objInvestimento.PrecoAtivo = DataGridView1.Rows(indice).Cells(5).Value

                Txt_quantidade.Text = DataGridView1.Rows(indice).Cells(6).Value

                Txt_TotalAplicado.Text = DataGridView1.Rows(indice).Cells(5).Value * DataGridView1.Rows(0).Cells(6).Value

                Cmb_NomeCarteira.SelectedValue = DataGridView1.Rows(indice).Cells(0).Value

                ''objInvestimento.IdTipoAtivo = DataGridView1.Rows(i).Cells(3).Value
                'ControladorInvestimento.InsereInvestimento(objInvestimento)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Txt_quantidade_TextChanged(sender As Object, e As EventArgs) Handles Txt_quantidade.TextChanged
        Try

            If String.IsNullOrEmpty(Txt_quantidade.Text) Then
                Txt_quantidade.Focus()
                Txt_TotalAplicado.Text = ""
            ElseIf String.IsNullOrEmpty(txt_preco.Text) Then
                txt_preco.Focus()
                Txt_TotalAplicado.Text = ""
            Else

                TotalInvestido()
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click

        Me.Close()

    End Sub

    Private Sub txt_preco_TextChanged(sender As Object, e As EventArgs) Handles txt_preco.TextChanged
        Try
            If String.IsNullOrEmpty(Txt_quantidade.Text) Then
                txt_preco.Focus()
                Txt_TotalAplicado.Text = ""
            ElseIf String.IsNullOrEmpty(txt_preco.Text) Then
                txt_preco.Focus()
                Txt_TotalAplicado.Text = ""

            Else

                TotalInvestido()
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class