﻿Imports System.Drawing.Drawing2D

Public Class ListControlItem

    Public Event SelectionChanged(sender As Object)

    Friend WithEvents tmrMouseLeave As New System.Windows.Forms.Timer With {.Interval = 10}

#Region "Properties"

    Dim mImage As Image
    Public Property Image() As Image
        Get
            Return mImage
        End Get
        Set(ByVal value As Image)
            mImage = value
            Refresh()
        End Set
    End Property

    Dim mSong As String = "[Song Name]"
    Public Property Song() As String
        Get
            Return mSong
        End Get
        Set(ByVal value As String)
            mSong = value
            Refresh()
        End Set
    End Property

    Dim mArtist As String = "[Artist]"
    Public Property Artist() As String
        Get
            Return mArtist
        End Get
        Set(ByVal value As String)
            mArtist = value
            Refresh()
        End Set
    End Property

    'Dim mAlbum As String = "[Album]"
    'Public Property Album() As String
    '    Get
    '        Return mAlbum
    '    End Get
    '    Set(ByVal value As String)
    '        mAlbum = value
    '        Refresh()
    '    End Set
    'End Property

    Dim mDuration As String
    Public Property Duration() As String
        Get
            Return lblDuration.Text
        End Get
        Set(ByVal value As String)
            lblDuration.Text = value
        End Set
    End Property

    Private mSelected As Boolean
    Public Property Selected() As Boolean
        Get
            Return mSelected
        End Get
        Set(ByVal value As Boolean)
            mSelected = value
            Refresh()
        End Set
    End Property

    'Public Property Rating() As Integer
    '    Get
    '        Return RatingBar1.Stars
    '    End Get
    '    Set(ByVal value As Integer)
    '        RatingBar1.Stars = value
    '    End Set
    'End Property


#End Region

#Region "Mouse coding"

    Private Enum MouseCapture
        Outside
        Inside
    End Enum
    Private Enum ButtonState
        ButtonUp
        ButtonDown
        Disabled
    End Enum
    Dim bState As ButtonState
    Dim bMouse As MouseCapture

    Private Sub ListControlItem_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If Selected = False Then
            Selected = True
            RaiseEvent SelectionChanged(Me)
        End If
    End Sub

    Private Sub ListControlItem_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Selected = False Then
            Selected = True
            RaiseEvent SelectionChanged(Me)
        End If
    End Sub

    Private Sub ListControlItem_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If Selected = False Then
            Selected = True
            RaiseEvent SelectionChanged(Me)
        End If
    End Sub

    Private Sub ListControlItem_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If Selected = False Then
            Selected = True
            RaiseEvent SelectionChanged(Me)
        End If
    End Sub

    Private Sub metroRadioGroup_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown ', rdButton.MouseDown
        bState = ButtonState.ButtonDown
        Refresh()
    End Sub

    Private Sub metroRadioGroup_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        bMouse = MouseCapture.Inside
        tmrMouseLeave.Start()
        Refresh()
    End Sub

    Private Sub metroRadioGroup_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp ', rdButton.MouseUp
        bState = ButtonState.ButtonUp
        Refresh()
    End Sub

    Private Sub tmrMouseLeave_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMouseLeave.Tick
        On Error Resume Next
        Dim scrPT = Control.MousePosition
        Dim ctlPT As Point = Me.PointToClient(scrPT)
        '
        If ctlPT.X < 0 Or ctlPT.Y < 0 Or ctlPT.X > Me.Width Or ctlPT.Y > Me.Height Then
            ' Stop timer
            tmrMouseLeave.Stop()
            bMouse = MouseCapture.Outside
            Refresh()
        Else
            bMouse = MouseCapture.Inside
        End If
    End Sub
#End Region

#Region "Painting"

    Private Sub Paint_DrawBackground(gfx As Graphics)
        '
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        '/// Build a rounded rectangle
        Dim p As New GraphicsPath
        Const Roundness = 5
        p.StartFigure()
        p.AddArc(New Rectangle(rect.Left, rect.Top, Roundness, Roundness), 180, 90)
        p.AddLine(rect.Left + Roundness, 0, rect.Right - Roundness, 0)
        p.AddArc(New Rectangle(rect.Right - Roundness, 0, Roundness, Roundness), -90, 90)
        p.AddLine(rect.Right, Roundness, rect.Right, rect.Bottom - Roundness)
        p.AddArc(New Rectangle(rect.Right - Roundness, rect.Bottom - Roundness, Roundness, Roundness), 0, 90)
        p.AddLine(rect.Right - Roundness, rect.Bottom, rect.Left + Roundness, rect.Bottom)
        p.AddArc(New Rectangle(rect.Left, rect.Height - Roundness, Roundness, Roundness), 90, 90)
        p.CloseFigure()


        '/// Draw the background ///
        Dim ColorScheme As Color() = Nothing
        Dim brdr As SolidBrush = Nothing

        If bState = ButtonState.Disabled Then
            ' normal
            brdr = ColorSchemes.DisabledBorder
            ColorScheme = ColorSchemes.DisabledAllColor
        Else
            If mSelected Then
                ' Selected
                brdr = ColorSchemes.SelectedBorder

                If bState = ButtonState.ButtonUp And bMouse = MouseCapture.Outside Then
                    ' normal
                    ColorScheme = ColorSchemes.SelectedNormal

                ElseIf bState = ButtonState.ButtonUp And bMouse = MouseCapture.Inside Then
                    '  hover 
                    ColorScheme = ColorSchemes.SelectedHover

                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Outside Then
                    ' no one cares!
                    Exit Sub
                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Inside Then
                    ' pressed
                    ColorScheme = ColorSchemes.SelectedPressed
                End If

            Else
                ' Not selected
                brdr = ColorSchemes.UnSelectedBorder

                If bState = ButtonState.ButtonUp And bMouse = MouseCapture.Outside Then
                    ' normal
                    brdr = ColorSchemes.DisabledBorder
                    ColorScheme = ColorSchemes.UnSelectedNormal

                ElseIf bState = ButtonState.ButtonUp And bMouse = MouseCapture.Inside Then
                    '  hover 
                    ColorScheme = ColorSchemes.UnSelectedHover

                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Outside Then
                    ' no one cares!
                    Exit Sub
                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Inside Then
                    ' pressed
                    ColorScheme = ColorSchemes.UnSelectedPressed
                End If

            End If
        End If

        ' Draw
        Dim b As LinearGradientBrush = New LinearGradientBrush(rect, Color.White, Color.Black, LinearGradientMode.Vertical)
        Dim blend As ColorBlend = New ColorBlend
        blend.Colors = ColorScheme
        blend.Positions = New Single() {0.0F, 0.1, 0.9F, 0.95F, 1.0F}
        b.InterpolationColors = blend
        gfx.FillPath(b, p)

        '// Draw border
        gfx.DrawPath(New Pen(brdr), p)

        '// Draw bottom border if Normal state (not hovered)
        If bMouse = MouseCapture.Outside Then
            rect = New Rectangle(rect.Left, Me.Height - 1, rect.Width, 1)
            b = New LinearGradientBrush(rect, Color.Blue, Color.Yellow, LinearGradientMode.Horizontal)
            blend = New ColorBlend
            blend.Colors = New Color() {Color.White, Color.LightGray, Color.White}
            blend.Positions = New Single() {0.0F, 0.5F, 1.0F}
            b.InterpolationColors = blend
            '
            gfx.FillRectangle(b, rect)
        End If
    End Sub

    Private Sub Paint_DrawButton(gfx As Graphics)
        Dim fnt As Font = Nothing
        Dim sz As SizeF = Nothing
        Dim layoutRect As RectangleF
        Dim SF As New StringFormat With {.Trimming = StringTrimming.EllipsisCharacter}
        Dim workingRect As New Rectangle(50, 0, lblDuration.Left - 15 - 6, Me.Height)

        ' Draw song name
        fnt = New Font("Segoe UI Light", 12)
        sz = gfx.MeasureString(mSong, fnt)
        layoutRect = New RectangleF(50, 0, workingRect.Width, sz.Height)
        gfx.DrawString(mSong, fnt, Brushes.Black, layoutRect, SF)

        ' Draw artist name
        fnt = New Font("Segoe UI Light", 9)
        sz = gfx.MeasureString(mArtist, fnt)
        layoutRect = New RectangleF(50, 22, Me.Width - 30, sz.Height)
        gfx.DrawString(mArtist, fnt, Brushes.Black, layoutRect, SF)

        ' Album Image
        If mImage IsNot Nothing Then
            gfx.DrawImage(mImage, New Point(7, 7))
        Else
            gfx.DrawImage(ImageList1.Images(0), New Point(7, 7))
        End If

    End Sub

    Private Sub PaintEvent(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim gfx = e.Graphics

        Paint_DrawBackground(gfx)
        Paint_DrawButton(gfx)
    End Sub

#End Region

End Class
