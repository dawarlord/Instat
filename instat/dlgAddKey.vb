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

Imports instat.Translations

Public Class dlgAddKey
    Dim bFirstLoad As Boolean = True

    Private Sub dlgAddKey_Load(sender As Object, e AsEventArgs) Handles MyBase.Load
        'ucrBase.iHelpTopicID()= # NO ID assigned to it yet 
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverKeyColumns.Selector = ucrSelectorKeyColumns
        ucrReceiverKeyColumns.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$add_key")
        ucrInputKeyName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorKeyColumns.Reset()
        ucrInputKeyName.ResetText()
        ucrInputCheckInput.ResetText()
    End Sub

    Private Sub ReOpenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverKeyColumns.IsEmpty()) AndAlso (Not ucrInputKeyName.IsEmpty())) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

End Class