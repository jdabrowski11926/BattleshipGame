Informacje na temat zadania o grze "Battleships".

Do rozwiązania zadania wykorzystano Visual Studio. Jest to aplikacja Windows Forms, projekt o strukturze .NET Core 3.1. 

Klasy oraz metody projektu:

1. Klasa "Program" - klasa uruchomieniowa zawierająca funkcję main

2. Klasa "BattleshipGameForm" - klasa odpowiadająca za logikę interfejsu oraz główną pętlę symulacji.
	2.1. Metoda "runGame" - główna pętla symulacji, uruchamiana na oddzielnym wątku
	2.2. Metoda "playOneTurn" - wszystkie akcje jakie są wykonywane w trakcie tury gracza
	2.3. Metoda "updateBoards" - odświerzenie grafiki obu plasz graczy
	2.4. Metoda "updateLabels" - odświerzenie liczby życia obu graczy
	2.5. Metoda "drawTile" - rysowanie pojedynczego pola na planszy
	2.6. Metoda "buttonNewGame_Click" - akcje wykonywane przy wciśnięciu przycisku "New Game". 
		Ładowane jest wtedy nowe ułożenie statków na planszach
	2.7. Metoda "buttonApplyChanges_Click" - akcje wykonywane przy wciśnięciu przycisku "Apply changes". 
		Po wciśnięciu zmieniana jest liczba milisekund pomiędzy turami graczy
	2.8. Metoda "terminateOldThread" - zakończenie procesu odpowiedzialnego za poprzednią rozgrywkę
	2.9. Metoda "selectStardingPlayer" - losowanie, który graczy rozpoczyna rozgrywkę
	2.10. Metoda getEnemyBattleshipBoard" - pobranie graczy przeciwnika

3. Klasa "BattleshipBoard" - klasa odzpowiedzialna za logikę planszy gracza
	3.1. Metoda "resetBoard" - załadowanie nowej planszy oraz ustawienie statków
	3.2. Metoda "initializeBoard" - załadowanie nowej planszy, na początku wszystkie pola puste
	3.3. Metoda "placeBattleships" - ułożenie wszystkich statków na planszy
	3.4. Metoda "placeBattleship" - ułożenie jednego statku o określonej długości
	3.5. Metoda "isPlacementPossible" - czy jest możliwe ułożenie statku o podanych właściwościach
	3.6. Metoda "markBattleshipOnBoard" - zaznaczenie statku na planszy
	3.7. Metoda "getBoardState" - pobranie stanu planszy o podanych koordynatach
	3.8. Metoda "getBoardSize" - pobranie wielkości planszy
	3.9. Metoda "getShipTiles" - pobranie ilości pól z pozostałymi statkami
	3.10. Metoda "markHit" - zaznaczenie podanego pola jako trafionego

4. Klasa "Player" - klasa odpowiedzialna za logikę gracza
	4.1. Metoda "studyEnemyBoard" - utworzenie listy możliwych strzałów
	4.2. Metoda "randomGuess" - wybranie losowego pola przeciwnika