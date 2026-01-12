## Funkciók
- Felhasználók listázása (GET `/api/felhasznalo`)
- Felhasználó lekérése ID alapján (GET `/api/felhasznalo/{id}`)
- Felhasználó létrehozása (POST `/api/felhasznalo`)
- Service és repository réteg kialakítása
- In-Memory vagy SQLite adatbázis használata (InMemory alapértelmezett)
- Dependency Injection alkalmazása
- Swagger dokumentáció elérhető

## Követelmények
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Telepítés és futtatás
1. Klónozd a repót:
```bash
git clone <repo-url>
cd user-manager-backend
dotnet restore
dotnet run