# _Scrabble_

#### _A C# Console Application to play Scrabble, March 2020_

#### By _**Jeremy Padot && K. Wicz**_


## Description

_A console application that takes a word and returns the Scrabble score for that word._

Scoring Key:
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10

## Behavior Driven Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
|Application takes in a string | empty | error|
| | "12" | error |
|Application takes in a string and returns points based on words letter value| "at" | 2 |
| |"dog" | 5 |

## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone https://github.com/kwicz/scrabble.git
```
3.  Enter into the new file directory
```sh
cd scrabble
```
4.  Start the program
```sh
dotnet run
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/scrabble/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Jeremy Padot && K.Wicz_**