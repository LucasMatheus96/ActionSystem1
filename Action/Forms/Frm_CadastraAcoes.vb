Imports Action.classes
Imports Action.Controller

Public Class Frm_CadastraAcoes

    Dim objAcao As New Acao
    Dim Dt As DataTable
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Dt = objAcao.ConsultarTipoAcao
        For i As Integer = 0 To Dt.Rows.Count - 1
            Cmb_Tipoacao.Items.Add(Dt.Rows(i)("NomeTipoAcao"))
        Next


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
        If ValidaCampos() = True Then

            objAcao.NomeAtivo = txt_NomeEmpresa.Text
            objAcao.SetorAtivo = Txt_SetorAtivo.Text
            objAcao.SiglaAtivo = Txt_Sigla.Text
            objAcao.IdTipoAcao = Cmb_Tipoacao.SelectedIndex + 1
            objAcao.CadastrarAcao(objAcao)
            MsgBox("Cadastro Efetuado com sucesso")
            LimparCampos()
        End If

    End Sub

    Private Sub Frm_CadastraAcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function ValidaCampos() As Boolean
        Dim vRetorno As Boolean
        If txt_NomeEmpresa.Text = String.Empty Then
            MsgBox("Preencha o campo Nome empresa")
            txt_NomeEmpresa.Focus()
            vRetorno = False
        ElseIf Txt_SetorAtivo.Text = String.Empty Then
            MsgBox("Preencha o campo Setor Ativo")
            Txt_SetorAtivo.Focus()
            vRetorno = False

        ElseIf Txt_Sigla.Text = String.Empty Then
            MsgBox("Preencha o Sigla")
            Txt_Sigla.Focus()
            vRetorno = False
        ElseIf Cmb_Tipoacao.SelectedIndex < 0 Then
            MsgBox("Preencha o Tipo De ação")
            Cmb_Tipoacao.Focus()
            vRetorno = False

        Else
            vRetorno = True

        End If
        Return vRetorno
    End Function






End Class