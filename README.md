# Faculty Resource Management System (FRMS)

Sistem za organizovanje i optimiziranje upotrebe resursa fakulteta (prostorije, računare i druge opreme)

## Članovi tima

1. Lamija Lemeš
2. Amila Fejzić
3. Adnan Elezović

## Opis Teme

Kreiranje pregleda dobrog rasporeda časova tako da svaki predavač ima zadovoljavajuću salu i svu opremu potrebnu za rad je dug proces koji često ne dovodi do optimalnih rezultata. 
Svrha ove aplikacije je da olakša pregled, administriranje i samo generisanje rasporeda
sala. Aplikacija će pružiti uvid korisnicima (tutorima, profesorima...) u stanje slobodnih 
sala, i bit će u stanju da provjere da li postoji slobodna sala koja koja zadovoljava 
njihove potrebe. Pored toga, aplikacija generiše raspored po salama, nastavnim grupama, 
predmetima i predavačima. 

## Procesi

Administrator sistema vrši ažuriranje informacija o raspoloživim salama (registracija broja sala, broj računara u pojedinačnim salama odnosno broj mjesta itd.). Za svaki termin (tutorijal, lab. vježba ili predavanje) dolazi
do promjene sedmičnog rasporeda. 

Ukoliko administrator registruje promjenu u sali, svi relevantni korisnici (predavači koji u svom rasporedu 
imaju tu salu) dobivaju notifikaciju. 
Predavači vrše unos svih svojih planiranih termina i navode potrebne resurse za iste. Zahtjev za termin 
validira i ukoliko postoji sala u tom terminu koja ispunjava uvjete raspored se ažurira i šalje se 
zahtijev administratoru za odobrenje. 

## Funkcionalnosti

- mogućnost unosa sala i podataka o njima 
- mogućnost kreiranja grupa 
- rezervisanje sala za zaseban termin ili u sklopu sedmičnog rasporeda
- pregled rasporeda po: salama, grupama, predmetima, predavačima
- obavještavanje o promjenama u salama (kvarovi i sl.)

## Akteri

- Administrator: unosi i ažurira sale i kreira korisničke račune za predavače
- Korisnik (profesor/tutor): rezerviše sale i kreira grupe