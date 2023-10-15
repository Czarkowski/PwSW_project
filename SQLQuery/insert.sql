INSERT INTO `PasiekaSchema`.`Ul`
(
`Numer`,
`DataDodania`,
`DataOstatniegoPrzegladu`,
`WiekMatki`,
`WiekMatkiData`,
`Rasa`,
`OpisStanu`,
`CzyOdklad`,
`CzyNowaMatka`,
`CzyWyrojone`)
VALUES
(0,
NOW(),
NOW(),
0,
NOW(),
'RasaTestowa',
'Testowy Opis Stanu',
false,
true,
false);
