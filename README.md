# TTTGame - Tic Tac Toe Game

TTTGame to gra "Kółko i krzyżyk" stworzona przy użyciu Windows Forms w języku C# z wykorzystaniem bazy danych SQLite. Projekt oferuje tryb dla dwóch graczy oraz możliwość gry przeciwko botom o różnym poziomie trudności. Aplikacja pozwala również na śledzenie wyników graczy w tablicy wyników.

## Funkcje

- **Tryb dla dwóch graczy**: Graj z przyjacielem na jednym urządzeniu.
- **Gra przeciwko botom**: Wybierz jeden z dwóch poziomów trudności bota: Easy lub Hard.
- **Tablica wyników**: Śledź wyniki graczy i ich ranking ELO.
- **Wielorundowe rozgrywki**: Ustaw liczbę rund w trybie "Best-of".

## Instalacja

1. **Klonowanie repozytorium**
   ```bash
   git clone https://github.com/mlodyg2137/TTTGame.git
   ```
2. **Otwórz projekt w Visual Studio**
   - Upewnij się, że masz zainstalowany .NET Framework 4.7.2 lub nowszy.
3. **Przygotowanie bazy danych**
   - Aplikacja automatycznie utworzy bazę danych SQLite przy pierwszym uruchomieniu.

4. **Uruchomienie projektu**
   - Uruchom projekt za pomocą Visual Studio (`F5` lub `Ctrl + F5`).

## Użycie

### Menu główne

Po uruchomieniu aplikacji zobaczysz menu główne, które pozwala na:
- **Rozpoczęcie nowej gry**: Przejście do ustawień gry.
- **Przeglądanie tablicy wyników**: Zobaczenie wyników i rankingu graczy.
- **Zamknięcie aplikacji**: Wyjście z gry.

### Ustawienia gry

- **Wybór pseudonimu**: Ustaw swój pseudonim oraz, opcjonalnie, pseudonim przeciwnika.
- **Wybór przeciwnika**: Wybierz, czy chcesz grać przeciwko innemu graczowi, Easy Botowi, czy Hard Botowi.
- **Best-of**: Ustaw liczbę rund potrzebnych do wygrania rozgrywki.

### Rozgrywka

- **Plansza**: Klikaj na pola, aby postawić "X" lub "O". W zależności od ustawień, możesz grać przeciwko innemu graczowi lub botowi.
- **Wyniki**: Wyniki poszczególnych rund są wyświetlane na ekranie, a końcowy wynik trafia do tablicy wyników.

### Tablica wyników

- **Ranking**: Gracze są uszeregowani według punktów ELO, które są obliczane na podstawie wyników ich gier.
- **Historia gier**: Przeglądaj wyniki poszczególnych graczy.

## Struktura projektu

- **Formularze**
  - `form_menu.cs`: Główne menu aplikacji.
  - `form_game.cs`: Formularz gry obsługujący logikę rozgrywki.
- **Kontrolki użytkownika**
  - `usercontrol_gamesettings.cs`: Ustawienia gry, pozwalające na wybór przeciwnika i trybu gry.
  - `usercontrol_leaderboard.cs`: Tablica wyników, wyświetlająca ranking graczy.
- **Logika gry**
  - `GameData.cs`: Przechowuje stan gry i wyniki.
  - `Field.cs`: Reprezentuje pojedyncze pole na planszy.
- **Boty**
  - `Bot.cs`: Abstrakcyjna klasa bazowa dla botów.
  - `EasyBot.cs`: Prosty bot, który wykonuje losowe ruchy.
  - `HardBot.cs`: Zaawansowany bot, który używa algorytmu minimax do podejmowania decyzji.

## Wymagania systemowe

- Windows 7 lub nowszy
- .NET Framework 4.7.2 lub nowszy
- Visual Studio 2019 lub nowszy (opcjonalnie do edycji i uruchamiania projektu)

## Autor

- **Imię i nazwisko**: Kamil Szpechciński
- **Email**: kamilsz2002@mat.umk.pl
- **GitHub**: [mlodyg2137](https://github.com/mlodyg2137)

## Licencja

TTTGame jest dostępne na licencji MIT. 
