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

    End Sub

    Private Sub Frm_GerenciarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConfigurarGrid()

        With Dgw_Ativos

            dtConsultaRegistroInvestimentos = controladorInvestimento.ConsultaInvestimentos(ObjAtributos.AtbId)
            Dgw_Ativos.DataSource = dtConsultaRegistroInvestimentos

            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False

            .Columns("PrecoTotal").HeaderText = "Valor total aplicado"
            .Columns("PrecoTotal").DefaultCellStyle.Format = "C2"
            .Columns("NomeAtivo").HeaderText = "Instituição Financeira"

            .Columns("SiglaATivo").HeaderText = "Ativo"

            .Columns("PrecoAtivo").HeaderText = "Preco da ultima compra"
            .Columns("PrecoAtivo").DefaultCellStyle.Format = "C2"

            .Columns("TipoAtivo").HeaderText = "Tipo Ativo"

            .Columns("NomeCarteira").HeaderText = "Carteira"

            .Columns("NomeCarteira").DisplayIndex = 1

            .Columns("TipoAtivo").DisplayIndex = 2


            .Columns("TipoAtivo").ReadOnly = True
            .Columns("NomeCarteira").ReadOnly = True
            .Columns("SiglaATivo").ReadOnly = True
            .Columns("IdAtivo").ReadOnly = True





        End With



    End Sub

    Private Sub Btn_ComprarAtivo_Click(sender As Object, e As EventArgs) Handles Btn_ComprarAtivo.Click
        Try
            Dim f As New Frm_ProdutoCarteira
            f.ShowDialog()
            ConfigurarGrid()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Private Sub Btn_AlterarAtivo_Click(sender As Object, e As EventArgs) Handles Btn_AlterarAtivo.Click



        'DialogResult = MessageBox.Show("Confirma a alteração ?", "Atenção.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)


        Dim indice As Integer = Dgw_Ativos.SelectedCells(0).RowIndex

        Dim objInvestimento As New Investimento
        Dim controladorInvestimento As New ControladorInvestimento

        For i As Integer = 0 To Dgw_Ativos.Rows.Count - 1
            objInvestimento.Id = Dgw_Ativos.Rows(i).Cells("Id").Value
            objInvestimento.NomeAtivo = Dgw_Ativos.Rows(i).Cells("NomeAtivo").Value
            objInvestimento.SiglaAtivo = Dgw_Ativos.Rows(i).Cells("SiglaAtivo").Value
            objInvestimento.IdAtivo = Dgw_Ativos.Rows(i).Cells("IdAtivo").Value
            objInvestimento.PrecoAtivo = Dgw_Ativos.Rows(i).Cells("PrecoAtivo").Value
            objInvestimento.Quantidade = Dgw_Ativos.Rows(i).Cells("Quantidade").Value
            objInvestimento.PrecoTotal = Dgw_Ativos.Rows(i).Cells("PrecoTotal").Value
            objInvestimento.IdCarteira = Dgw_Ativos.Rows(i).Cells("IdCarteira").Value
            objInvestimento.IdTipoAtivo = Dgw_Ativos.Rows(i).Cells("IdTipoAtivo").Value
            ControladorInvestimento.AlteraInvestimento(objInvestimento)
        Next
        MessageBox.Show("Alteração efetuada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ConfigurarGrid()





        'Dim alteraProduto As New Frm_ProdutoCarteira
        'alteraProduto.Txt_descricao.Text = Dgw_Ativos.Rows(0).Cells(1).Value
        'alteraProduto.Cmb_NomeCarteira.Text = Dgw_Ativos.SelectedRows(0).Cells(11).Value
        'alteraProduto.Cmb_TipoAtivo.SelectedIndex = Dgw_Ativos.SelectedRows(0).Cells("IdTipoAtivo").Value
        'alteraProduto.Cmb_Ativo.Text = Dgw_Ativos.SelectedRows(0).Cells("SiglaAtivo").Value
        'alteraProduto.txt_preco.Text = Dgw_Ativos.SelectedRows(0).Cells("PrecoAtivo").Value
        'alteraProduto.Txt_quantidade.Text = Dgw_Ativos.SelectedRows(0).Cells("Quantidade").Value
        'alteraProduto.Txt_TotalAplicado.Text = Dgw_Ativos.SelectedRows(0).Cells("PrecoTotal").Value
        'alteraProduto.Btn_Adicionar.Text = "Alterar"
        'alteraProduto.ShowDialog()

        'ConfigurarGrid()


    End Sub

    Private Sub PreencheComboBoxFiltro()

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
        'txt_busca1.Visible = False
        'txt_busca2.Visible = False



    End Sub

    Private Sub Cmb_Filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Filtro.SelectedIndexChanged
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

    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click

        If Cmb_Filtro.SelectedItem = "Data" Then
            Dim dataInicial As Date = DateTimePicker1.Value
            Dim dataFinal As DateTime = DateTimePicker2.Value

            Dgw_Ativos.DataSource = BuscaInvestimentoData(ObjAtributos.AtbId, dataInicial, dataFinal)

        ElseIf Cmb_Filtro.SelectedItem = "Nome da carteira" Then

            Dgw_Ativos.DataSource = BuscaInvestimentoNomeCarteira(ObjAtributos.AtbId, Txt_Busca.Text)


        ElseIf Cmb_Filtro.SelectedItem = "Sigla Ativo" Then

            Dgw_Ativos.DataSource = BuscaInvestimentoSiglaAtivo(ObjAtributos.AtbId, Txt_Busca.Text)

        ElseIf Cmb_Filtro.SelectedItem = "Instituição Financeira" Then

            Dgw_Ativos.DataSource = BuscaInvestimentoInstFinanceira(ObjAtributos.AtbId, Txt_Busca.Text)

        ElseIf Cmb_Filtro.SelectedItem = "Tipo Ativo" Then

            Dgw_Ativos.DataSource = BuscaInvestimentoIdTipoAtivo(ObjAtributos.AtbId, Cmb_TipoAtivo.SelectedIndex)

        Else
            ConfigurarGrid()
        End If


    End Sub

    Private Sub PreencheComboboxTipoAtivo()

        Dim lista As New List(Of String)
        lista.Add("<Selecione>")
        lista.Add("RendaFixa")
        lista.Add("Ação")
        lista.Add("Fundo imobiliario")

        For i As Integer = 0 To lista.Count - 1
            Cmb_TipoAtivo.Items.Add(lista(i))
        Next

        Cmb_TipoAtivo.SelectedIndex = 0

    End Sub






    Private Function BuscaInvestimentoData(iOperador As Integer, dataInicial As DateTime, dataFinal As DateTime) As DataTable

        Dim dtFiltro As New DataTable
        Dim controladorInvestimento As New ControladorInvestimento

        dtFiltro = controladorInvestimento.PesquisaInvestimentoPorFiltroData(iOperador, dataInicial, dataFinal)

        Return dtFiltro

    End Function

    Private Function BuscaInvestimentoNomeCarteira(iOperador As Integer, nomeCarteira As String) As DataTable

        Dim dtFiltro As New DataTable
        Dim controladorInvestimento As New ControladorInvestimento

        dtFiltro = controladorInvestimento.BuscaInvestimentoNomeCarteira(iOperador, nomeCarteira)

        Return dtFiltro

    End Function

    Private Function BuscaInvestimentoSiglaAtivo(iOperador As Integer, siglaAtivo As String) As DataTable

        Dim dtFiltro As New DataTable
        Dim controladorInvestimento As New ControladorInvestimento

        dtFiltro = controladorInvestimento.BuscaInvestimentoSiglaAtivo(iOperador, siglaAtivo)

        Return dtFiltro

    End Function

    Private Function BuscaInvestimentoInstFinanceira(iOperador As Integer, instFinanceira As String) As DataTable


        Dim controladorInvestimento As New ControladorInvestimento

        Return controladorInvestimento.BuscaInvestimentoInstFinanceira(iOperador, instFinanceira)



    End Function

    Private Function BuscaInvestimentoIdTipoAtivo(iOperador As Integer, idTipoAtivo As Integer) As DataTable

        Dim dtFiltro As New DataTable
        Dim controladorInvestimento As New ControladorInvestimento

        dtFiltro = controladorInvestimento.BuscaInvestimentoTipoAtivo(iOperador, idTipoAtivo)

        Return dtFiltro

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