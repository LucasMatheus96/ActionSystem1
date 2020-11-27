Imports System.ComponentModel
Imports Action.classes
Imports Action.Controller

Public Class Frm_Login
    Dim Usuario As New Usuario
    Dim controlUsuario As New ControladorUsuario
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Action"
        btn_Logar.Text = "Acessar"
        Btn_Cancelar.Text = "Cancelar"
        Lbl_Login.Text = "Nome Usuario"
        Lbl_Senha.Text = "Senha"
        Lbl_Cadastro.Text = "Cadastra-se"
        Lbl_AlterarSenha.Text = "Esqueci minha senha"


    End Sub

    Private Sub Frm_Login_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed

        Try
            If controlUsuario.ValidarAcesso(Txt_Login.Text, Txt_Passoword.Text).Rows.Count = 0 Then
                Me.Close()
                Frm_Principal.Close()
            Else
                Me.Close()
            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try




    End Sub




    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click

        Try
            Me.Close()
            Frm_Principal.Close()
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub



    Private Sub Lbl_Cadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_Cadastro.LinkClicked

        Try
            Dim f As New Frm_TelaCadastro
            f.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Lbl_AlterarSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_AlterarSenha.LinkClicked

        Try
            Dim f As New Frm_AlteraSenha
            f.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub



    Private Sub Frm_Login_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Frm_Principal.Show()
    End Sub

    Private Sub Btn_Logar_Click(sender As Object, e As EventArgs) Handles btn_Logar.Click


        Try
            Dim vLogin As String = Txt_Login.Text
            Dim vSenha As String = Txt_Passoword.Text

            If controlUsuario.ChecarCampos(vLogin, vSenha) = False Then
                Exit Sub
            End If

            If controlUsuario.ValidarAcesso(vLogin, vSenha).Rows.Count = 1 Then

                MessageBox.Show("Acesso Autorizado")
                Me.Close()
                Frm_Principal.Show()
                Frm_Principal.Tsl_UsuarioLogado.Visible = True
                Frm_Principal.Tsl_UsuarioLogado.Text = "Usuario Logado: " + Txt_Login.Text


            Else
                MsgBox("Usuario ou senha Incorreta", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Login_KeyPress(sender As Object, e As KeyEventArgs) Handles Txt_Login.KeyDown
        If e.KeyValue = Keys.Enter Then
            Txt_Passoword.Focus()
        End If
    End Sub

    Private Sub Txt_Passoword_KeyPress(sender As Object, e As KeyEventArgs) Handles Txt_Passoword.KeyDown
        If e.KeyValue = Keys.Enter Then
            btn_Logar.Focus()
        End If
    End Sub
End Class
