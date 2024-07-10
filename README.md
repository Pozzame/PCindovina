# PCindovina

```mermaid
flowchart TD
    A[Start] --> B[Initialize array of dice]
    B --> C[Create Random object]
    C --> D[Lancio i 5 dadi]
    D --> E[Display dice values]
    E --> F[Ask which dice to change]
    F --> G[Read input string]
    G --> H[Convert input to list]
    H --> I[Rilancia solo i dadi da cambiare]
    I --> J[Display updated dice values]
    J --> K[Calcolo punteggio]
    K --> L[Initialize total score]
    L --> M{Iterate through dice}
    M --> N[Initialize partial score]
    M --> O{Check for duplicates}
    O --> |Yes| P[Increase partial score]
    O --> |No| Q[Continue loop]
    P --> Q
    Q --> R{Update total score if partial is higher}
    R --> |Yes| S[Update total score]
    R --> |No| T[Continue loop]
    S --> T
    T --> M
    M --> U[Display total score - 1]
    U --> V[End]
```