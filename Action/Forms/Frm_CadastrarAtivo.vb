Public Class Frm_CadastrarAtivo
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Cadastrando Ativos"

    End Sub

    Private Sub Frm_CadastrarAtivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_CadastrarAcao.Click
        Dim f As New Frm_CadastraAcoes
        f.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_CadastrarRendaFixa.Click
        Dim f As New Frm_CadastraRendaFixa
        f.ShowDialog()

    End Sub

    Private Sub Btn_CadastrarFI_Click(sender As Object, e As EventArgs) Handles Btn_CadastrarFI.Click
        Dim f As New Frm_CadastraFI
        f.ShowDialog()
    End Sub
End Class