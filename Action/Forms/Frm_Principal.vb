﻿Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Action"

    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New Frm_Login
        f.ShowDialog()
    End Sub

    Private Sub CadastrarCarteiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarCarteiraToolStripMenuItem.Click
        Dim f As New Frm_CadastroCarteira
        f.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Tsl_UsuarioLogado_Click(sender As Object, e As EventArgs) Handles Tsl_UsuarioLogado.Click

    End Sub

    Private Sub ConsultarCarteiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCarteiraToolStripMenuItem.Click
        Dim f As New Frm_ConsultaCarteira
        f.ShowDialog()
    End Sub

    Private Sub EfetuarNovoAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfetuarNovoAcessoToolStripMenuItem.Click

        Dim f1 As New Frm_Login
        f1.ShowDialog()
    End Sub

    Private Sub CadastrarAtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarAtivosToolStripMenuItem.Click
        Dim f As New Frm_CadastrarAtivo
        f.ShowDialog()
    End Sub

    Private Sub ConsultarAtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarAtivosToolStripMenuItem.Click
        Dim f As New frm_ConsultarAtivo
        f.showDialog()
    End Sub
End Class