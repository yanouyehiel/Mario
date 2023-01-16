Public Class Mario
    Private _CoordonneesActuelles As Point
    Private _Taille As Size

    Sub New(ByVal PositionOriginelle As Point, ByVal TailleMario As Size)
        _CoordonneesActuelles = New Point(PositionOriginelle)
        _Taille = New Size(TailleMario)
    End Sub

    Public Sub Avance()
        _CoordonneesActuelles.X = _CoordonneesActuelles.X + _PasX()
    End Sub
    Public Sub Recule()
        _CoordonneesActuelles.X = _CoordonneesActuelles.X - _PasX()
    End Sub
    Public Sub Monte()
        _CoordonneesActuelles.Y = _CoordonneesActuelles.Y - _PasY()
    End Sub
    Public Sub Descend()
        _CoordonneesActuelles.Y = _CoordonneesActuelles.Y + _PasY()
    End Sub

#Region "Fonctions privées"
    Private Function _PasX()
        Return _Taille.Width
    End Function
    Private Function _PasY()
        Return _Taille.Height
    End Function
#End Region

    Public Property Position() As Point
        Get
            Return _CoordonneesActuelles
        End Get
        Set(ByVal value As Point)
            _CoordonneesActuelles = value
        End Set
    End Property
End Class
