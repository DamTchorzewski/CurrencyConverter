---
layout: default
title: Kalkulator Walut
---

# Kalkulator Walut

**Kalkulator Walut** to aplikacja Windows Forms służąca jako kalkulator konwersji walut. Projekt został opracowany zgodnie z wymogami specyfikacji, oferując intuicyjny interfejs użytkownika oraz funkcjonalności takie jak dynamiczne etykiety walut, obsługa niestandardowej waluty i przeliczanie wartości na podstawie predefiniowanych kursów wymiany.

---

## Funkcje aplikacji

1. **Wprowadzanie wartości waluty:**

   - Użytkownicy mogą wprowadzać kwotę waluty źródłowej w polu tekstowym.

2. **Sterowanie za pomocą paska przewijania:**

   - Wartość waluty źródłowej można ustawić również za pomocą poziomego paska przewijania (hScrollBar).

3. **Przeliczanie walut:**

   - Aplikacja konwertuje wartość waluty źródłowej na docelową, wykorzystując zdefiniowane kursy wymiany.
   - Wybór waluty źródłowej i docelowej odbywa się za pomocą przycisków radiowych (RadioButton).

4. **Waluta niestandardowa:**

   - Niestandardowa waluta o nazwie "DT" (pochodzącej od inicjałów autora), której kurs wymiany wynosi 722,06 (zgodnie z numerem indeksu autora).

5. **Dynamiczne etykiety:**

   - Nazwy walut w etykietach zmieniają się dynamicznie na podstawie wyboru użytkownika.

6. **Obsługa błędów:**

   - Walidacja danych liczbowych w polu tekstowym, aby uniknąć błędów.
   - Wyświetlanie komunikatów o błędach w przypadku nieprawidłowego wprowadzenia danych.

7. **Predefiniowane kursy wymiany:**

   - Kursy walut są zapisane w tablicy, co zapewnia szybkie przeliczanie i łatwą modyfikację.

---

## Zaimplementowane zdarzenia

1. **Zmiana tekstu w polu wejściowym (`TextBox.TextChanged`):**

   - Waliduje wprowadzone dane i wywołuje funkcję przeliczania waluty docelowej.

2. **Zmiana wartości paska przewijania (`HScrollBar.ValueChanged`):**

   - Synchronizuje wartość paska przewijania z polem tekstowym.

3. **Zmiana waluty (`RadioButton.CheckedChanged`):**

   - Aktualizuje etykiety waluty źródłowej i docelowej oraz ponownie przelicza wartości walut.

4. **Automatyczne przeliczanie waluty:**

   - Wywoływane przy każdej zmianie wartości źródłowej lub wyborze innej waluty.

---

## Ograniczenia i możliwe usprawnienia

- **Interfejs użytkownika:**

  - Interfejs graficzny mógłby zostać unowocześniony w celu poprawy estetyki i lepszej użyteczności.

- **Brak obsługi języków:**

  - Obecnie aplikacja obsługuje jedynie etykiety i komunikaty w języku angielskim.

- **Dynamiczne kursy wymiany:**

  - Kursy są statycznie zakodowane i nie są aktualizowane w czasie rzeczywistym.

---

## Samoocena projektu

Projekt w pełni realizuje założenia specyfikacji, a wszystkie wymagane funkcjonalności zostały zaimplementowane. Dodatkowo aplikacja zawiera obsługę błędów, integrację z paskiem przewijania oraz dynamicznie zmieniające się etykiety walut. Wprowadzenie waluty niestandardowej również zostało zrealizowane zgodnie z założeniami.

### **Sugerowana ocena: 5/5**

Projekt spełnia wszystkie wymagania i działa zgodnie z oczekiwaniami, co uzasadnia najwyższą ocenę.

---

## Instrukcja uruchomienia

1. Otwórz projekt w środowisku Visual Studio.
2. Wybierz opcję „Build” i uruchom aplikację.
3. Korzystaj z interfejsu graficznego do testowania funkcjonalności konwersji walut.

---

## Autor

[Damian Tchorzewski 72206]
