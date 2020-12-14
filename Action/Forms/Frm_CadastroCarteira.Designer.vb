<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastroCarteira
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastroCarteira))
        Me.Grp_CadastroCarteira = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Cadastrar = New System.Windows.Forms.Button()
        Me.Txt_NomeCarteira = New System.Windows.Forms.TextBox()
        Me.Lbl_NomeCarteira = New System.Windows.Forms.Label()
        Me.Grp_CadastroCarteira.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_CadastroCarteira
        '
        Me.Grp_CadastroCarteira.Controls.Add(Me.Btn_Cancelar)
        Me.Grp_CadastroCarteira.Controls.Add(Me.Btn_Cadastrar)
        Me.Grp_CadastroCarteira.Controls.Add(Me.Txt_NomeCarteira)
        Me.Grp_CadastroCarteira.Controls.Add(Me.Lbl_NomeCarteira)
        Me.Grp_CadastroCarteira.Location = New System.Drawing.Point(26, 24)
        Me.Grp_CadastroCarteira.Name = "Grp_CadastroCarteira"
        Me.Grp_CadastroCarteira.Size = New System.Drawing.Size(269, 119)
        Me.Grp_CadastroCarteira.TabIndex = 0
        Me.Grp_CadastroCarteira.TabStop = False
        Me.Grp_CadastroCarteira.Text = "GroupBox1"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(153, 69)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(110, 23)
        Me.Btn_Cancelar.TabIndex = 3
        Me.Btn_Cancelar.Text = "Button2"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Cadastrar
        '
        Me.Btn_Cadastrar.Location = New System.Drawing.Point(23, 69)
        Me.Btn_Cadastrar.Name = "Btn_Cadastrar"
        Me.Btn_Cadastrar.Size = New System.Drawing.Size(108, 23)
        Me.Btn_Cadastrar.TabIndex = 2
        Me.Btn_Cadastrar.Text = "Button1"
        Me.Btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'Txt_NomeCarteira
        '
        Me.Txt_NomeCarteira.Location = New System.Drawing.Point(23, 43)
        Me.Txt_NomeCarteira.Name = "Txt_NomeCarteira"
        Me.Txt_NomeCarteira.Size = New System.Drawing.Size(240, 20)
        Me.Txt_NomeCarteira.TabIndex = 1
        '
        'Lbl_NomeCarteira
        '
        Me.Lbl_NomeCarteira.AutoSize = True
        Me.Lbl_NomeCarteira.Location = New System.Drawing.Point(20, 27)
        Me.Lbl_NomeCarteira.Name = "Lbl_NomeCarteira"
        Me.Lbl_NomeCarteira.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_NomeCarteira.TabIndex = 0
        Me.Lbl_NomeCarteira.Text = "Label1"
        '
        'Frm_CadastroCarteira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 181)
        Me.Controls.Add(Me.Grp_CadastroCarteira)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_CadastroCarteira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_CadastroCarteira"
        Me.Grp_CadastroCarteira.ResumeLayout(False)
        Me.Grp_CadastroCarteira.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grp_CadastroCarteira As GroupBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Cadastrar As Button
    Friend WithEvents Txt_NomeCarteira As TextBox
    Friend WithEvents Lbl_NomeCarteira As Label
End Class
