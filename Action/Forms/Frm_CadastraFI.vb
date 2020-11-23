Imports Action.classes

Public Class Frm_CadastraFI
    Dim objFundoImobiliario As New FundoImobiliario
    Dim dt As New DataTable
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Cadastro de Fundo Imobiliario"
        dt = objFundoImobiliario.ConsultarTipoFundoImobiliario
        For i As Integer = 0 To dt.Rows.Count - 1
            Cmb_FundoImobiliario.Items.Add(dt.Rows(i)("NomeTipoFundo"))
        Next

    End Sub

    Private Sub Frm_CadastrarFI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click


        objFundoImobiliario.NomeAtivo = Txt_NomeFundoImobiliario.Text
        objFundoImobiliario.SiglaAtivo = Txt_SiglaFundoImobiliario.Text
        objFundoImobiliario.IdTipoFundoImobiliario = Cmb_FundoImobiliario.SelectedIndex + 1
        objFundoImobiliario.CadastrarFundoImobiliario(objFundoImobiliario)
    End Sub
End Class