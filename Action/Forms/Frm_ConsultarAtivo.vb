Imports Action.classes

Public Class Frm_ConsultarAtivo

    Dim Index As Integer = 0
    Dim objAtivo As New RendaFixa
    Dim objAcoes As New Acao
    Dim objFundoImobiliario As New FundoImobiliario
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Consultar Ativos Cadastrados"
        FormatarListView()
        CriarColunas()
        Lsw_ListaDeAtivos.Items.Clear()
        CarregaListView()
        CarregaGridViewAcoes()
        CarregaGridViewfundoImobiliario()

    End Sub

    Private Sub Frm_ConsultarAtivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub CarregaListView()

        Dim Dt As DataTable
        Dt = objAtivo.ConsultarRendaFixa

        For Each linha As DataRow In Dt.Rows
            Dim lista As New ListViewItem()
            lista.Text = linha("Id").ToString()
            lista.SubItems.Add(linha("NomeAtivo").ToString())
            lista.SubItems.Add(linha("Rendimento").ToString())
            lista.SubItems.Add(linha("Sigla").ToString())


            Lsw_ListaDeAtivos.Items.Add(lista)

        Next
    End Sub
    Sub FormatarListView()
        ' Formatar o ListView

        Lsw_ListaDeAtivos.View = View.Details
        Lsw_ListaDeAtivos.LabelEdit = False
        Lsw_ListaDeAtivos.AllowColumnReorder = False
        Lsw_ListaDeAtivos.FullRowSelect = True
        Lsw_ListaDeAtivos.GridLines = True

    End Sub



    Sub CriarColunas()
        ' Configurar colunas

        Lsw_ListaDeAtivos.Columns.Add("Id", 100, HorizontalAlignment.Center)
        Lsw_ListaDeAtivos.Columns.Add("NomeAtivo", 150, HorizontalAlignment.Center)
        Lsw_ListaDeAtivos.Columns.Add("Rendimento", 150, HorizontalAlignment.Center)
        Lsw_ListaDeAtivos.Columns.Add("Sigla", 100, HorizontalAlignment.Center)
    End Sub

    Private Sub Btn_Alterar_Click(sender As Object, e As EventArgs) Handles Btn_Alterar.Click

        Try
            If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Then

                Dim AlterarRendaFixa As New Frm_CadastraRendaFixa

                AlterarRendaFixa.idRendaFixa = Integer.Parse(Lsw_ListaDeAtivos.Items(Index).Text)
                AlterarRendaFixa.txt_titulo.Text = Lsw_ListaDeAtivos.Items(Index).SubItems(1).Text
                AlterarRendaFixa.TxT_RentabilidadeTitulo.Text = Lsw_ListaDeAtivos.Items(Index).SubItems(2).Text
                AlterarRendaFixa.ShowDialog()
                Lsw_ListaDeAtivos.Items.Clear()
                CarregaListView()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Lsw_ListaDeAtivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lsw_ListaDeAtivos.SelectedIndexChanged
        Try
            If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Then

                Index = Lsw_ListaDeAtivos.SelectedItems(0).Index

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Then

            Try
                objAtivo.Id = Integer.Parse(Lsw_ListaDeAtivos.SelectedItems(0).Text)
                objAtivo.ExcluirRendaFixa(objAtivo.Id)
                MsgBox("Registro excluido com sucesso.")
                Lsw_ListaDeAtivos.Items.Clear()
                CarregaListView()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try



        End If
    End Sub

    Private Sub CarregaGridViewAcoes()
        DataGridView_Acoes.DataSource = objAcoes.ConsultarAcao


        With DataGridView_Acoes
            .Columns(0).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False



        End With

    End Sub

    Private Sub CarregaGridViewfundoImobiliario()
        DataGridView_FundoImobiliario.DataSource = objFundoImobiliario.ConsultarFundoImobiliario


        With DataGridView_FundoImobiliario
            .Columns(0).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False


            .Columns(1).Width = 200
            .Columns(2).Width = 60
            .Columns(5).Width = 200


        End With

    End Sub

End Class