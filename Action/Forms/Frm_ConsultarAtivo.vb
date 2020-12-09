Imports Action.classes
Imports Action.Controller

Public Class Frm_ConsultarAtivo

    Dim Index As Integer = 0

    Dim objAtivo As New RendaFixa
    Dim objAcoes As New Acao
    Dim objFundoImobiliario As New FundoImobiliario
    Dim controlAcao As New ControladorAcao
    Dim controlFundoImobiliario As New ControladorFundoImobiliario
    Dim controlRendaFixa As New ControladorRendaFixa



    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Consultar Ativos Cadastrados"
        FormatarListView()
        CriarColunas()
        Lsw_ListaDeAtivos.Items.Clear()
        CarregaListView()


    End Sub

    Private Sub Frm_ConsultarAtivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregaGridViewAcoes()
        CarregaGridViewfundoImobiliario()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub CarregaListView()

        Try
            Dim Dt As DataTable

            Dt = controlRendaFixa.ConsultarRendaFixa

            For Each linha As DataRow In Dt.Rows
                Dim lista As New ListViewItem()
                lista.Text = linha("Id").ToString()
                lista.SubItems.Add(linha("NomeAtivo").ToString())
                lista.SubItems.Add(linha("Rendimento").ToString())
                lista.SubItems.Add(linha("Sigla").ToString())


                Lsw_ListaDeAtivos.Items.Add(lista)

            Next



        Catch ex As Exception
            Throw ex
        End Try





    End Sub
    Sub FormatarListView()
        ' Formatar o ListView
        Try

            Lsw_ListaDeAtivos.View = View.Details
            Lsw_ListaDeAtivos.LabelEdit = False
            Lsw_ListaDeAtivos.AllowColumnReorder = False
            Lsw_ListaDeAtivos.FullRowSelect = True
            Lsw_ListaDeAtivos.GridLines = True
        Catch ex As Exception
            Throw ex
        End Try


    End Sub



    Sub CriarColunas()
        ' Configurar colunas

        Try

            Lsw_ListaDeAtivos.Columns.Add("Id", 100, HorizontalAlignment.Center)
            Lsw_ListaDeAtivos.Columns.Add("NomeAtivo", 150, HorizontalAlignment.Center)
            Lsw_ListaDeAtivos.Columns.Add("Rendimento", 150, HorizontalAlignment.Center)
            Lsw_ListaDeAtivos.Columns.Add("Sigla", 100, HorizontalAlignment.Center)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Btn_Alterar_Click(sender As Object, e As EventArgs) Handles Btn_Alterar.Click

        Try


            If ValidaGrids() = True Then

                'If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Or DataGridView_Acoes.Rows(Index2).Selected = True Or DataGridView_FundoImobiliario.Rows(Index2).Selected = True Then

                If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Then


                    Dim AlterarRendaFixa As New Frm_CadastraRendaFixa

                    AlterarRendaFixa.idRendaFixa = Integer.Parse(Lsw_ListaDeAtivos.Items(Index).Text)
                    AlterarRendaFixa.txt_titulo.Text = Lsw_ListaDeAtivos.Items(Index).SubItems(1).Text
                    AlterarRendaFixa.TxT_RentabilidadeTitulo.Text = Lsw_ListaDeAtivos.Items(Index).SubItems(2).Text
                    AlterarRendaFixa.ShowDialog()
                    Lsw_ListaDeAtivos.Items.Clear()
                    CarregaListView()

                ElseIf DataGridView_Acoes.SelectedRows().Count > 0 Then

                    Dim alterarAcao As New Frm_CadastraAcoes
                    alterarAcao.IdAcao = Integer.Parse(DataGridView_Acoes.SelectedRows(0).Cells(0).Value)
                    alterarAcao.txt_NomeEmpresa.Text = DataGridView_Acoes.SelectedRows(0).Cells(1).Value
                    alterarAcao.Txt_Sigla.Text = DataGridView_Acoes.SelectedRows(0).Cells(3).Value
                    alterarAcao.Txt_SetorAtivo.Text = DataGridView_Acoes.SelectedRows(0).Cells(2).Value
                    alterarAcao.Cmb_Tipoacao.Text = DataGridView_Acoes.SelectedRows(0).Cells(6).Value
                    alterarAcao.Btn_Cadastrar.Text = "Alterar"
                    alterarAcao.ShowDialog()
                    CarregaGridViewAcoes()

                ElseIf DataGridView_FundoImobiliario.SelectedRows.Count > 0 Then

                    Dim alterarFundo As New Frm_CadastraFI
                    alterarFundo.idFundoImobiliario = Integer.Parse(DataGridView_FundoImobiliario.SelectedRows(0).Cells(0).Value)
                    alterarFundo.Txt_NomeFundoImobiliario.Text = DataGridView_FundoImobiliario.SelectedRows(0).Cells(1).Value
                    alterarFundo.Txt_SiglaFundoImobiliario.Text = DataGridView_FundoImobiliario.SelectedRows(0).Cells(2).Value
                    alterarFundo.Cmb_FundoImobiliario.Text = DataGridView_FundoImobiliario.SelectedRows(0).Cells(5).Value
                    alterarFundo.Btn_Cadastrar.Text = "Alterar"
                    alterarFundo.ShowDialog()
                    DataGridView_FundoImobiliario.Rows.Clear()
                    CarregaGridViewAcoes()


                End If
            Else
                MessageBox.Show("Selecione algum item para ser alterado")

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


        Try

            If ValidaGrids() = True Then
                If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Then


                    objAtivo.Id = Integer.Parse(Lsw_ListaDeAtivos.SelectedItems(0).Text)
                    controlRendaFixa.ExcluirRendaFixa(objAtivo.Id)
                    MsgBox("Registro excluido com sucesso.")
                    Lsw_ListaDeAtivos.Items.Clear()
                    CarregaListView()

                End If

                If DataGridView_Acoes.SelectedRows().Count > 0 Then
                    objAcoes.Id = Integer.Parse(DataGridView_Acoes.SelectedRows(0).Cells(0).Value)
                    controlAcao.ExcluirAcao(objAcoes.Id)
                    MessageBox.Show("Registro excluido com sucesso.")
                    CarregaGridViewAcoes()

                End If

                If DataGridView_FundoImobiliario.SelectedRows().Count > 0 Then
                    objAcoes.Id = Integer.Parse(DataGridView_Acoes.SelectedRows(0).Cells(0).Value)
                    controlAcao.ExcluirAcao(objAcoes.Id)
                    MessageBox.Show("Registro excluido com sucesso.")
                    CarregaGridViewAcoes()

                End If
            Else
                MessageBox.Show("Selecione algum item para ser alterado")
            End If

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CarregaGridViewAcoes()
        Try
            DataGridView_Acoes.DataSource = controlAcao.ConsultarAcao


            With DataGridView_Acoes
                .Columns(0).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False

                .ClearSelection()
            End With
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub CarregaGridViewfundoImobiliario()
        Try

            DataGridView_FundoImobiliario.DataSource = controlFundoImobiliario.ConsultarFundoImobiliario


            With DataGridView_FundoImobiliario
                .Columns(0).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False


                .Columns(1).Width = 200
                .Columns(2).Width = 60
                .Columns(5).Width = 200
                .ClearSelection()


            End With
        Catch ex As Exception
            Throw ex
        End Try


    End Sub


    Private Sub Lsw_ListaDeAtivos_Click(sender As Object, e As EventArgs) Handles Lsw_ListaDeAtivos.Click
        Try
            If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Then
                DataGridView_Acoes.ClearSelection()
                DataGridView_FundoImobiliario.ClearSelection()
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DataGridView_Acoes_Click(sender As Object, e As EventArgs) Handles DataGridView_Acoes.Click
        Try
            DataGridView_FundoImobiliario.ClearSelection()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DataGridView_FundoImobiliario_Click(sender As Object, e As EventArgs) Handles DataGridView_FundoImobiliario.Click
        Try
            DataGridView_Acoes.ClearSelection()
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Function ValidaGrids() As Boolean

        Try
            Dim vRetorno As Boolean
            If Lsw_ListaDeAtivos.SelectedItems.Count > 0 Or DataGridView_Acoes.SelectedRows.Count > 0 Or DataGridView_FundoImobiliario.SelectedRows.Count > 0 Then
                vRetorno = True
            End If

            Return vRetorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function


End Class