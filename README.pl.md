# Kalkulator Walut

**Kalkulator Walut** to aplikacja Windows Forms opracowana w środowisku Visual Studio .NET Framework. Służy ona do przeliczania wartości walut na podstawie predefiniowanych kursów wymiany, zapewniając intuicyjny interfejs użytkownika oraz dodatkowe funkcjonalności zgodne z wymaganiami projektu.

---

## Funkcje aplikacji

1. **Wprowadzanie wartości waluty:**
   - Użytkownicy mogą wpisać kwotę waluty źródłowej w pierwszym polu tekstowym (textBox1).

2. **Sterowanie za pomocą paska przewijania:**
   - Poziomy pasek przewijania (hScrollBar) umożliwia ustawienie wartości waluty źródłowej.

3. **Przeliczanie walut:**
   - Aplikacja konwertuje wartość waluty źródłowej na docelową, korzystając z predefiniowanych kursów wymiany.
   - Użytkownicy mogą wybrać walutę źródłową i docelową za pomocą przycisków radiowych (RadioButton).

4. **Waluta niestandardowa:**
   - Zgodnie z wymogami projektu, wprowadzono walutę o nazwie "DT" (pochodzącą od inicjałów autora), której kurs wynosi 722,06 (zgodnie z numerem indeksu autora).

5. **Dynamiczne etykiety walut:**
   - Nazwy walut w etykietach zmieniają się automatycznie w zależności od wybranych opcji.

6. **Obsługa błędów:**
   - Walidacja danych wejściowych w polu tekstowym (textBox1) zapobiega wprowadzaniu niepoprawnych wartości.
   - Komunikaty o błędach informują użytkownika o konieczności poprawnego wprowadzenia danych.

7. **Predefiniowane kursy wymiany:**
   - Kursy walut są zapisane w tablicy, co zapewnia szybkie i łatwe przeliczanie oraz możliwość ich modyfikacji w przyszłości.

---

## Zaimplementowane zdarzenia

1. **Zmiana tekstu w polu wejściowym (TextBox.TextChanged):**
   - Waliduje wprowadzone dane i automatycznie aktualizuje wynik przeliczenia.

2. **Sterowanie paskiem przewijania (HScrollBar.ValueChanged):**
   - Synchronizuje wartość paska przewijania z polem tekstowym.

3. **Zmiana waluty źródłowej i docelowej (RadioButton.CheckedChanged):**
   - Aktualizuje etykiety walut oraz wynik przeliczenia.

4. **Walidacja znaków (TextBox.KeyPress):**
   - Ogranicza wprowadzanie znaków do cyfr, przecinka oraz klawiszy sterujących.

---

## Ograniczenia i możliwe usprawnienia

1. **Interfejs użytkownika:**
   - Można rozważyć modernizację interfejsu graficznego, np. dodanie stylów lub responsywności.

2. **Brak dynamicznych kursów wymiany:**
   - Obecnie kursy walut są zakodowane na stałe. Możliwość pobierania danych z zewnętrznego API zwiększyłaby funkcjonalność aplikacji.

3. **Obsługa wielu języków:**
   - Aplikacja mogłaby obsługiwać różne języki w interfejsie użytkownika.

---

## Samoocena projektu

Projekt spełnia wszystkie założenia specyfikacji:
- Obsługuje wprowadzanie i przeliczanie walut.
- Zaimplementowano walutę niestandardową zgodnie z wymogami.
- Wprowadzono walidację danych wejściowych oraz dynamiczne etykiety walut.

**Sugerowana ocena:** 5/5

---

## Instrukcja uruchomienia

1. Otwórz projekt w Visual Studio.
2. Zbuduj aplikację, wybierając opcję "Build".
3. Uruchom aplikację i korzystaj z funkcji kalkulatora walut poprzez interfejs graficzny.

---

## Autor

[Damian Tchorzewski, indeks: 72206]
