# Kalkulator Walut

**Kalkulator Walut** to aplikacja Windows Forms s�u��ca jako kalkulator konwersji walut. Projekt zosta� opracowany zgodnie z wymogami specyfikacji, oferuj�c intuicyjny interfejs u�ytkownika oraz funkcjonalno�ci takie jak dynamiczne etykiety walut, obs�uga niestandardowej waluty i przeliczanie warto�ci na podstawie predefiniowanych kurs�w wymiany.

---

## Funkcje aplikacji

1. **Wprowadzanie warto�ci waluty:**
   - U�ytkownicy mog� wprowadza� kwot� waluty �r�d�owej w polu tekstowym.

2. **Sterowanie za pomoc� paska przewijania:**
   - Warto�� waluty �r�d�owej mo�na ustawi� r�wnie� za pomoc� poziomego paska przewijania (hScrollBar).

3. **Przeliczanie walut:**
   - Aplikacja konwertuje warto�� waluty �r�d�owej na docelow�, wykorzystuj�c zdefiniowane kursy wymiany.
   - Wyb�r waluty �r�d�owej i docelowej odbywa si� za pomoc� przycisk�w radiowych (RadioButton).

4. **Waluta niestandardowa:**
   - Niestandardowa waluta o nazwie "DT" (pochodz�cej od inicja��w autora), kt�rej kurs wymiany wynosi 722,06 (zgodnie z numerem indeksu autora).

5. **Dynamiczne etykiety:**
   - Nazwy walut w etykietach zmieniaj� si� dynamicznie na podstawie wyboru u�ytkownika.

6. **Obs�uga b��d�w:**
   - Walidacja danych liczbowych w polu tekstowym, aby unikn�� b��d�w.
   - Wy�wietlanie komunikat�w o b��dach w przypadku nieprawid�owego wprowadzenia danych.

7. **Predefiniowane kursy wymiany:**
   - Kursy walut s� zapisane w tablicy, co zapewnia szybkie przeliczanie i �atw� modyfikacj�.

---

## Zaimplementowane zdarzenia

1. **Zmiana tekstu w polu wej�ciowym (`TextBox.TextChanged`):**
   - Waliduje wprowadzone dane i wywo�uje funkcj� przeliczania waluty docelowej.

2. **Zmiana warto�ci paska przewijania (`HScrollBar.ValueChanged`):**
   - Synchronizuje warto�� paska przewijania z polem tekstowym.

3. **Zmiana waluty (`RadioButton.CheckedChanged`):**
   - Aktualizuje etykiety waluty �r�d�owej i docelowej oraz ponownie przelicza warto�ci walut.

4. **Automatyczne przeliczanie waluty:**
   - Wywo�ywane przy ka�dej zmianie warto�ci �r�d�owej lub wyborze innej waluty.

---

## Ograniczenia i mo�liwe usprawnienia

- **Interfejs u�ytkownika:**
  - Interfejs graficzny m�g�by zosta� unowocze�niony w celu poprawy estetyki i lepszej u�yteczno�ci.

- **Brak obs�ugi j�zyk�w:**
  - Obecnie aplikacja obs�uguje jedynie etykiety i komunikaty w j�zyku angielskim.

- **Dynamiczne kursy wymiany:**
  - Kursy s� statycznie zakodowane i nie s� aktualizowane w czasie rzeczywistym.

---

## Samoocena projektu

Projekt w pe�ni realizuje za�o�enia specyfikacji, a wszystkie wymagane funkcjonalno�ci zosta�y zaimplementowane. Dodatkowo aplikacja zawiera obs�ug� b��d�w, integracj� z paskiem przewijania oraz dynamicznie zmieniaj�ce si� etykiety walut. Wprowadzenie waluty niestandardowej r�wnie� zosta�o zrealizowane zgodnie z za�o�eniami.

### **Sugerowana ocena: 5/5**  
Projekt spe�nia wszystkie wymagania i dzia�a zgodnie z oczekiwaniami, co uzasadnia najwy�sz� ocen�.

---

## Instrukcja uruchomienia

1. Otw�rz projekt w �rodowisku Visual Studio.
2. Wybierz opcj� �Build� i uruchom aplikacj�.
3. Korzystaj z interfejsu graficznego do testowania funkcjonalno�ci konwersji walut.

---

## Autor
[Damian Tchorzewski 72206]
