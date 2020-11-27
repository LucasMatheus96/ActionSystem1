Imports Action.classes
Imports Action.Controller

Public Class Frm_CadastraFI
    Dim objFundoImobiliario As New FundoImobiliario
    Dim controlFundoImobiliario As New ControladorFundoImobiliario
    Dim dt As New DataTable
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Cadastro de Fundo Imobiliario"
        dt = controlFundoImobiliario.ConsultarTipoFundoImobiliario
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
        controlFundoImobiliario.CadastrarFundoImobiliario(objFundoImobiliario)
        MessageBox.Show("Cadastro efetuado com sucesso.")
        LimparCampos()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        Txt_NomeFundoImobiliario.Text = String.Empty
        Txt_SiglaFundoImobiliario.Text = String.Empty
        Cmb_FundoImobiliario.ResetText()
    End Sub
End Class