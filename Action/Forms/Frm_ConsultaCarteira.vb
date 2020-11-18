Imports Action.classes


Public Class Frm_ConsultaCarteira
    Dim Index As Integer = 0
    Dim objCarteira As New Carteira
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Consulta Carteira"
        txt_busca1.Visible = False
        txt_busca2.Visible = False
        CarregarListViewer()



    End Sub


    Private Sub CarregarListViewer()
        'Dim dt As New DataTable
        'dt = ojbCarteira.ConsultarCarteira

        'For Each linha As DataRow In dt.Rows
        '    Dim lista As New ListViewItem()
        '    lista.Text = linha("Id").ToString()
        '    lista.SubItems.Add(linha("NomeCarteira").ToString())
        '    lista.SubItems.Add(linha("DataTransacao").ToString())
        '    lista.SubItems.Add(linha("iOperador").ToString())


        '    Dt_CarteiraGridView.Rows.Add(linha),


        Lsw_VerCarteira.Items.Clear()
        Dim dt As New DataTable
        dt = objCarteira.ConsultarCarteira()

        For Each linha As DataRow In dt.Rows
            Dim lista As New ListViewItem()
            lista.Text = linha("Id").ToString()
            lista.SubItems.Add(linha("NomeCarteira").ToString())
            lista.SubItems.Add(linha("DataTransacao").ToString())
            lista.SubItems.Add(linha("iOperador").ToString())


            Lsw_VerCarteira.Items.Add(lista)

        Next


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            If Lsw_VerCarteira.Items.Count > 0 Then


                Dim AlterarCarteira As New Frm_CadastroCarteira
                AlterarCarteira.IdCarteira = Integer.Parse(Lsw_VerCarteira.Items(Index).Text)
                AlterarCarteira.Txt_NomeCarteira.Text = Lsw_VerCarteira.Items(Index).SubItems(0).Text
                AlterarCarteira.ShowDialog()
                CarregarListViewer()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Lsw_VerCarteira_Click(sender As Object, e As EventArgs) Handles Lsw_VerCarteira.Click

        Try
            If Lsw_VerCarteira.SelectedItems.Count > 0 Then

                Index = Lsw_VerCarteira.SelectedItems(0).Index

            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If Lsw_VerCarteira.SelectedItems.Count > 0 Then
                objCarteira.Id = (Integer.Parse(Lsw_VerCarteira.SelectedItems(0).Text))
                objCarteira.ExcluirCarteira(objCarteira.Id)
                CarregarListViewer()
            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Cmb_Filtro_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Filtro.SelectedValueChanged
        If Cmb_Filtro.SelectedItem = "Selecione" Then
            txt_busca1.Visible = False
            txt_busca2.Visible = False
            Lbl_a.Text = ""
        ElseIf Cmb_Filtro.SelectedItem = "Data" Then

            txt_busca1.Visible = True
            txt_busca2.Visible = True

        Else
            MsgBox("nome Carteira")
            txt_busca1.Visible = True
            txt_busca2.Visible = False
            Lbl_a.Text = ""

        End If
    End Sub

    Private Sub Frm_ConsultaCarteira_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Grb_ConsultaCarteira_Enter(sender As Object, e As EventArgs) Handles Grb_ConsultaCarteira.Enter

    End Sub
End Class