﻿' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Public Class dlgCalculationsSummary
    Public bFirstLoad As Boolean = True
    Private Sub dlgCalculationsSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub InitialiseDialog()

    End Sub
End Class