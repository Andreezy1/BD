SELECT DISTINCT Id,Data,Nomer_abonenta,Kod_mej,Nabir_nomer,Sostoyalsya,Dlitelnest, Tarif*DATEPART (MINUTE,[Dlitelnest]) as Stoimost
FROM Tarif,Zvonki
Where Kod_mej=Kod_mejgorod