﻿Option Strict On

Public Class OccurrenceGetter
    ' https://community.sw.siemens.com/s/question/0D54O000061xsxUSAQ/sorting-through-occurrences
    ' https://community.sw.siemens.com/s/question/0D54O00007OeUiYSAV/activate-all-parts-even-hidden-in-assembly-reaching-occsubocc-document-requires-activation

    Public AllOccurrenceNames As New List(Of String)
    Public AllSubOccurrenceNames As New List(Of String)

    Public AllOccurrences As New List(Of SolidEdgeAssembly.Occurrence)
    Public AllSubOccurrences As New List(Of SolidEdgeAssembly.SubOccurrence)

    Public Sub New(SEDoc As SolidEdgeAssembly.AssemblyDocument,
                   IgnoreIncludeInReportsFlag As Boolean,
                   Optional IncludeSubOccurrences As Boolean = True)

        'GetOccurrences(SEDoc)

        Dim Occurrences As SolidEdgeAssembly.Occurrences
        Dim Occurrence As SolidEdgeAssembly.Occurrence
        Dim SubOccurrences As SolidEdgeAssembly.SubOccurrences
        Dim SubOccurrence As SolidEdgeAssembly.SubOccurrence

        Occurrences = SEDoc.Occurrences

        For Each Occurrence In Occurrences
            AllOccurrenceNames.Add(Occurrence.Name)
            AllOccurrences.Add(Occurrence)

            If Occurrence.Subassembly Then
                SubOccurrences = Occurrence.SubOccurrences
                If Not SubOccurrences Is Nothing Then
                    For Each SubOccurrence In SubOccurrences
                        RecurseSubs(SubOccurrence, IgnoreIncludeInReportsFlag)
                    Next
                End If
            End If
        Next

    End Sub

    'Private Sub GetOccurrences(SEDoc As SolidEdgeAssembly.AssemblyDocument)

    '    Dim Occurrences As SolidEdgeAssembly.Occurrences = SEDoc.Occurrences
    '    Dim Occurrence As SolidEdgeAssembly.Occurrence

    '    If Occurrences.Count > 0 Then
    '        For Each Occurrence In Occurrences
    '            If Not AllOccurrences.Contains(Occurrence) Then
    '                AllOccurrenceNames.Add(Occurrence.Name)
    '                AllOccurrences.Add(Occurrence)

    '                If Occurrence.Subassembly Then
    '                    GetOccurrences(CType(Occurrence.OccurrenceDocument, SolidEdgeAssembly.AssemblyDocument))

    '                End If
    '            End If

    '        Next

    '    End If

    'End Sub

    Private Sub RecurseSubs(SubOccurrence As SolidEdgeAssembly.SubOccurrence,
                            IgnoreIncludeInReportsFlag As Boolean)

        Dim SubSubs As SolidEdgeAssembly.SubOccurrences
        Dim SubSub As SolidEdgeAssembly.SubOccurrence

        If Not AllSubOccurrences.Contains(SubOccurrence) Then
            AllSubOccurrences.Add(SubOccurrence)
            AllSubOccurrenceNames.Add(SubOccurrence.Name)
            If SubOccurrence.Subassembly Then
                SubSubs = SubOccurrence.SubOccurrences
                If Not SubSubs Is Nothing Then
                    For Each SubSub In SubSubs
                        RecurseSubs(SubSub, IgnoreIncludeInReportsFlag)
                    Next
                End If
            End If
            'If IgnoreIncludeInReportsFlag Then
            '    AllSubOccurrences.Add(SubOccurrence)
            '    AllSubOccurrenceNames.Add(SubOccurrence.Name)
            '    If SubOccurrence.Subassembly Then
            '        SubSubs = SubOccurrence.SubOccurrences
            '        For Each SubSub In SubSubs
            '            RecurseSubs(SubSub, IgnoreIncludeInReportsFlag)
            '        Next
            '    End If
            'Else
            '    If Not SubOccurrence.ExcludeFromReports Then
            '        AllSubOccurrences.Add(SubOccurrence)
            '        AllSubOccurrenceNames.Add(SubOccurrence.Name)
            '        If SubOccurrence.Subassembly Then
            '            SubSubs = SubOccurrence.SubOccurrences
            '            For Each SubSub In SubSubs
            '                RecurseSubs(SubSub, IgnoreIncludeInReportsFlag)
            '            Next
            '        End If
            '    End If
            'End If
        End If
    End Sub

    'Private Sub RecurseSubOccurrence(SubOccurrence As SolidEdgeAssembly.SubOccurrence)
    '    If Not AllSubOccurrences.Contains(SubOccurrence) Then
    '        AllSubOccurrences.Add(SubOccurrence)

    '    End If
    'End Sub



End Class

