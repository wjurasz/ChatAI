# 📌 Projekt Wojciech Jurasz

## 📋 Wymagania

- **Visual Studio 2022**
- **.NET 8** 
- **SQL Server** 
- **Konto API** 

## 🚀 Instalacja i uruchomienie

Aby uruchomić aplikację, wykonaj poniższe kroki:

### 1️⃣ Sklonowanie repozytorium
```sh
 git clone https://github.com/wjurasz/ProjektJezykiWebowe
 cd nazwa-repo
```

### 2️⃣ Otwórz projekt w Visual Studio 2022
Plik `*.sln` otwórz w Visual Studio 2022.

### 3️⃣ Utwórz migrację bazy danych
W **Package Manager Console** uruchom:
```sh
  Add-migration Nazwa
  Update-Database
```

### 4️⃣ Skonfiguruj klucze API
Dodaj odpowiednie klucze API do pliku
```json
"APIKeys": {
  "Groq": "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",
  "WeatherApi": "661cd2064114358ad7223220250102"
}
```


### 5️⃣ Uruchom projekt jako HTTPS
W Visual Studio:
- Wybierz **HTTPS**
- Kliknij **Run** (zielona strzałka)

## 🎯 Technologie
- C# / .NET
- ASP.NET Core
- Entity Framework
- SQL Server
- REST API
