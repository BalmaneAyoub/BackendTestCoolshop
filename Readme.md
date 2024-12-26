# Coolshop - Backend Test

Applicazione in C# progettata per analizzare i dati delle transazioni in un file CSV:

- L'ordine con il totale più alto senza applicare sconto.
- L'ordine con la maggiore quantità di articoli.
- L'ordine con la differenza di sconto più alta.


## Struttura del File CSV

Il file CSV deve essere strutturato nel seguente modo:

| Id | Nome Articolo | Quantità | Prezzo Unitario | Percentuale Sconto | Compratore |
|----|---------------|----------|-----------------|--------------------|------------|
| 1  | Coca-Cola     | 10       | 1.00            | 0%                 | Mario Rossi|
| 2  | Coca-Cola     | 15       | 2.00            | 0%                 | Luca Neri |
| 3  | Fanta         | 5        | 3.00            | 2%                 | Luca Neri |
| 4  | Acqua         | 20       | 1.00            | 10%                | Mario Rossi|
| 5  | Fanta         | 1        | 4.00            | 15%                | Andrea Bianchi|


## Funzionalità

- **Lettura e Parsing del CSV**: Il programma carica e legge un file CSV contenente le transazioni, estraendo i dati rilevanti.
- **Elaborazione Dati**: Calcola il totale per ogni transazione sia con che senza applicazione di sconto, e calcola anche la differenza tra il prezzo originale e quello scontato.
- **Generazione Report**: Identifica e restituisce il report per:
  - La transazione con il totale più alto senza sconto.
  - La transazione con la quantità di articoli maggiore.
  - La transazione con la maggiore differenza di sconto.
- **Visualizzazione in Console**: Mostra i risultati dei report in modo chiaro e leggibile sulla console.

## Come Utilizzare il Programma

### 1. Preparazione e Compilazione

- Clona il repository o scarica il codice sorgente.
- Apri il progetto in un IDE come Visual Studio.
- Compila ed esegui il progetto.

### 2. Esecuzione del Programma

- Scarica o crea un file CSV con i dati delle transazioni (assicurati che segua il formato sopra indicato).
- Avvia il programma.
- Quando richiesto, inserisci il percorso completo del file CSV da caricare.
  - Per trovare il percorso, fai clic con il tasto destro sul file CSV, seleziona "Proprietà" e copia il campo "Percorso".

### 3. Output dei Risultati

Il programma analizzerà i dati nel file CSV e stamperà i seguenti report nella console:

- **Transazione con il totale più alto senza sconto**.
- **Transazione con la quantità maggiore di articoli**.
- **Transazione con la maggiore differenza di sconto**.

### Esempio di Output

Transazione con il totale più alto senza sconto: Id: 2, Articolo: Coca-Cola, Quantità: 15, Prezzo Unitario: 2.00, Sconto: 0%, Compratore: Luca Neri

Transazione con la quantità più alta: Id: 4, Articolo: Acqua, Quantità: 20, Prezzo Unitario: 1.00, Sconto: 10%, Compratore: Mario Rossi

Transazione con la differenza di sconto più alta: Id: 5, Articolo: Fanta, Quantità: 1, Prezzo Unitario: 4.00, Sconto: 15%, Compratore: Andrea Bianchi

markdown
Copia codice

## Dettagli Tecnici

### Classi Principali

1. **Program**
   - Gestisce l'avvio dell'applicazione, la lettura del file CSV e la gestione dei report.
   - Controlla la presenza e la validità del file CSV.
   - Visualizza i report dei dati elaborati.

2. **Record**
   - Contiene le informazioni di una transazione (Id, Nome Articolo, Quantità, Prezzo Unitario, Percentuale Sconto, Compratore).
   - Metodi per:
     - **TotalnoDscount()**: Calcola il totale senza sconto.
     - **Total()**: Calcola il totale con sconto applicato.
     - **DiscountDifference()**: Calcola la differenza tra il totale senza sconto e quello con sconto.
     - **ReadCsv()**: Legge il file CSV e restituisce una lista di oggetti `Record`.
   
3. **OrderControll**
   - Metodi per analizzare i dati:
     - **GetHighestTotal()**: Restituisce il record con il totale più alto senza sconto.
     - **GetHighestQuantity()**: Restituisce il record con la quantità di articoli più alta.
     - **GetHighestDiscountDifference()**: Restituisce il record con la differenza di sconto più alta.
   
4. **Utility**
   - Funzioni ausiliarie per stampare i dettagli dei record in console.

### Gestione degli Errori

- **Controllo file**: Verifica che il file CSV esista prima di tentare di leggerlo.
- **Parsing CSV**: Ignora le righe incomplete o non valide, segnalando gli errori nel parsing.
- **Messaggi di errore**: Se non ci sono record o se i dati sono corrotti, il programma informerà l'utente con un messaggio adeguato.

