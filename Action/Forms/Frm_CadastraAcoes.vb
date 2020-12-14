Imports Action.Classes
Imports Action.Controller
Imports Action.DAO

Public Class Frm_CadastraAcoes

    Dim objAcao As New Acao
    Dim Dt As DataTable
    Dim acaoDAO As New AcaoDAO
    Dim control As New ControladorAcao

    Public IdAcao As Integer
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Dt = control.ConsultarTipoAcao
        For i As Integer = 0 To Dt.Rows.Count - 1
            Cmb_Tipoacao.Items.Add(Dt.Rows(i)("NomeTipoAcao"))
        Next

        Me.FormBorderStyle = FormBorderStyle.Fixed3D
    End Sub

    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        LimparCampos()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub LimparCampos()
        Try
            Txt_SetorAtivo.Text = String.Empty
            Txt_Sigla.Text = String.Empty
            txt_NomeEmpresa.Text = String.Empty
            Cmb_Tipoacao.ResetText()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click

        Try
            If ValidaCampos() = True Then
                If IdAcao = 0 Then
                    objAcao.NomeAtivo = txt_NomeEmpresa.Text
                    objAcao.SetorAtivo = Txt_SetorAtivo.Text
                    objAcao.SiglaAtivo = Txt_Sigla.Text
                    objAcao.IdTipoAcao = Cmb_Tipoacao.SelectedIndex + 1
                    control.CadastrarAcao(objAcao)
                    MessageBox.Show("Cadastro efetuado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimparCampos()
                Else
                    objAcao.Id = IdAcao
                    objAcao.NomeAtivo = txt_NomeEmpresa.Text
                    objAcao.SetorAtivo = Txt_SetorAtivo.Text
                    objAcao.SiglaAtivo = Txt_Sigla.Text
                    objAcao.IdTipoAcao = Cmb_Tipoacao.SelectedIndex + 1
                    control.AlterarAcao(objAcao)
                    MessageBox.Show("Cadastro alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub Frm_CadastraAcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function ValidaCampos() As Boolean

        Try
            Dim vRetorno As Boolean
            If txt_NomeEmpresa.Text = String.Empty Then
                MessageBox.Show("Preencha o campo nome da empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_NomeEmpresa.Focus()
                vRetorno = False
            ElseIf Txt_SetorAtivo.Text = String.Empty Then
                MessageBox.Show("Preencha o campo setor ativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Txt_SetorAtivo.Focus()
                vRetorno = False

            ElseIf Txt_Sigla.Text = String.Empty Then
                MessageBox.Show("Preencha o campo sigla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Txt_Sigla.Focus()
                vRetorno = False
            ElseIf Cmb_Tipoacao.SelectedIndex < 0 Then
                MessageBox.Show("Preencha o tipo de ação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Cmb_Tipoacao.Focus()
                vRetorno = False

            Else
                vRetorno = True

            End If
            Return vRetorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function






End Class