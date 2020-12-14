Imports System.Security.Cryptography
Imports Action.classes
Imports Action.Controller

Public Class Frm_TelaCadastro
    Dim controlUsuario As New ControladorUsuario

    Public classe As New Usuario()

    Public IdCliente As Integer = 0
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Cadastro de usuario"
        Grp_Cadastro.Text = "Cadastro"
        Grp_Permissao.Text = "Permissão"
        Lbl_Nome.Text = "Nome"
        Lbl_Senha.Text = "Senha"
        Lbl_Usuario.Text = "Usuario"
        Lbl_ConfirmaSenha.Text = "Digite novamente sua senha"
        Me.MaximizeBox = False

        'Nomeclatura dos checkbox
        CheckBox_Administrador.Text = "Administrador"
        CheckBox_Alterar.Text = "Alterar"
        Checkbox_CadastroAtivo.Text = "Cadastrar Ativos"
        CheckBox_Excluir.Text = "Excluir Ativos"
        CheckBox_Naosei.Text = "Pensando ainda"
        CheckBox_Permissao.Text = "Permissão"
        CheckBox_Relatorio.Text = "Relatórios"
        Check_Consulta.Text = "Consultar Ativos"

        'Nomeclatura dos Botões
        Btn_Cancelar.Text = "Cancelar"
        Btn_Confirmar.Text = "Confirmar"


        'chamadas


    End Sub

    Private Sub Frm_TelaCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub

    Private Sub Btn_Confirmar_Click(sender As Object, e As EventArgs) Handles Btn_Confirmar.Click

        Try

            If controlUsuario.ChecarCampos(Txt_Nome.Text, Txt_Senha.Text, Txt_Usuario.Text, Txt_ConfirmarSenha.Text) = False Then
            Else
                classe.Nome = Txt_Nome.Text
                classe.Usuario = Txt_Usuario.Text
                classe.Senha = Txt_Senha.Text

                'Valida os checkbox
                CheckBox()


                If IdCliente > 0 Then
                    classe.Id = IdCliente
                    controlUsuario.AtualizarUsuario(classe)
                    MsgBox("Usuario alterado com sucesso")

                Else
                    controlUsuario.CadastrarUsuario(classe)
                    MsgBox("Cadastro efetuado com sucesso")
                    LimparCampos()
                End If

            End If
        Catch ex As Exception
            Throw New Exception("Verifique os dados inseridos")
        End Try




    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub CheckBox_Administrador_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Administrador.CheckedChanged

        Try
            If CheckBox_Administrador.Checked Then
                CheckBox_Alterar.Checked = True
                Checkbox_CadastroAtivo.Checked = True
                CheckBox_Excluir.Checked = True
                CheckBox_Permissao.Checked = True
                CheckBox_Naosei.Checked = True
                CheckBox_Relatorio.Checked = True
                Check_Consulta.Checked = True

                Grp_Permissao.Enabled = False


            Else
                CheckBox_Alterar.Checked = False
                Checkbox_CadastroAtivo.Checked = False
                CheckBox_Excluir.Checked = False
                CheckBox_Permissao.Checked = False
                CheckBox_Naosei.Checked = False
                CheckBox_Relatorio.Checked = False
                Check_Consulta.Checked = False
                Grp_Permissao.Enabled = True
            End If

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try



    End Sub



    Private Sub Checkbox_CadastroAtivo_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_CadastroAtivo.CheckedChanged
        Try
            If Checkbox_CadastroAtivo.Checked = False Then
                CheckBox_Administrador.Checked = False
            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox_Alterar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Alterar.CheckedChanged
        Try
            If CheckBox_Alterar.Checked = False Then
                CheckBox_Administrador.Checked = False

            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Sub

    Private Sub Check_Consulta_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Consulta.CheckedChanged
        Try
            If Check_Consulta.Checked = False Then
                CheckBox_Administrador.Checked = False

            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox_Excluir_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Excluir.CheckedChanged

        Try
            If CheckBox_Excluir.Checked = False Then
                CheckBox_Administrador.Checked = False

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox_Permissao_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Permissao.CheckedChanged
        Try
            If CheckBox_Permissao.Checked = False Then
                CheckBox_Administrador.Checked = False

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox_Relatorio_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Relatorio.CheckedChanged

        Try
            If CheckBox_Relatorio.Checked = False Then
                CheckBox_Administrador.Checked = False

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox_Naosei_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Naosei.CheckedChanged
        Try
            If CheckBox_Naosei.Checked = False Then
                CheckBox_Administrador.Checked = False

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Btn_VerUsuarios_Click(sender As Object, e As EventArgs) 
        Try
            Dim f As New Frm_UsuariosCadastrados
            f.ShowDialog()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub

    Private Sub Txt_Nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nome.KeyPress
        If e.KeyChar = ChrW(13) Then
            Txt_Usuario.Focus()
        End If
    End Sub

    Private Sub Txt_Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Usuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Txt_Senha.Focus()
        End If
    End Sub

    Private Sub Txt_Senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Senha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Txt_ConfirmarSenha.Focus()

        End If
    End Sub

    Private Sub Txt_ConfirmarSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ConfirmarSenha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            'Btn_Confirmar.Focus()
            Checkbox_CadastroAtivo.Focus()
        End If
    End Sub

    Private Sub LimparCampos()
        Try
            Txt_ConfirmarSenha.Text = String.Empty
            Txt_Nome.Text = String.Empty
            Txt_Senha.Text = String.Empty
            Txt_Usuario.Text = String.Empty
            CheckBox_Administrador.Checked = False
            CheckBox_Alterar.Checked = False
            Checkbox_CadastroAtivo.Checked = False
            CheckBox_Excluir.Checked = False
            CheckBox_Permissao.Checked = False
            CheckBox_Naosei.Checked = False
            CheckBox_Relatorio.Checked = False
            Check_Consulta.Checked = False
        Catch ex As Exception
            Throw ex
        End Try


    End Sub


    Private Sub CheckBox()

        Try
            If CheckBox_Administrador.Checked Then

                classe.Permissao = "999;"
                Exit Sub
            End If
            If Checkbox_CadastroAtivo.Checked Then
                classe.Permissao += "001;"
            End If
            If CheckBox_Alterar.Checked Then
                classe.Permissao += "002;"
            End If
            If CheckBox_Excluir.Checked Then
                classe.Permissao += "003;"
            End If
            If CheckBox_Naosei.Checked Then
                classe.Permissao += "004;"
            End If
            If CheckBox_Relatorio.Checked Then
                classe.Permissao += "005;"

            End If
            If CheckBox_Permissao.Checked Then
                classe.Permissao += "006;"
            End If
            If Check_Consulta.Checked Then
                classe.Permissao += "007;"

            End If
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub CarregaCheckbox(vString As String)

        If vString.Equals("999;") Then
            CheckBox_Administrador.Checked = True

        End If
        If vString.Contains("001;") Then
            Checkbox_CadastroAtivo.Checked = True
        End If
        If vString.Contains("002;") Then
            CheckBox_Alterar.Checked = True

        End If
        If vString.Contains("003;") Then
            CheckBox_Excluir.Checked = True

        End If
        If vString.Contains("004;") Then
            CheckBox_Naosei.Checked = True

        End If
        If vString.Contains("005;") Then
            CheckBox_Relatorio.Checked = True


        End If
        If vString.Contains("006;") Then
            CheckBox_Permissao.Checked = True

        End If
        If vString.Contains("007;") Then
            Check_Consulta.Checked = True
        End If
    End Sub



End Class