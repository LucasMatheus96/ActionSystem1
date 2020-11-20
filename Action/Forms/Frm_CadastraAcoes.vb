Imports Action.classes

Public Class Frm_CadastraAcoes

    Dim objAcao As New Acao
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        LimparCampos()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub LimparCampos()
        Txt_SetorAtivo.Text = String.Empty
        Txt_Sigla.Text = String.Empty
        txt_NomeEmpresa.Text = String.Empty
        Cmb_Tipoacao.ResetText()
    End Sub

    Private Sub Btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click

        objAcao.NomeAtivo = txt_NomeEmpresa.Text
        objAcao.SetorAtivo = Txt_SetorAtivo.Text
        objAcao.SiglaAtivo = Txt_Sigla.Text
        objAcao.IdTipoAcao = Cmb_Tipoacao.SelectedIndex + 1
        objAcao.CadastrarAcao(objAcao)
    End Sub
End Class