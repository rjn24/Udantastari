# 🚀 UdanTastari

A simple 2D space-themed target shooting game developed in **Unity 2022.3.37f1** using **C#**.

This project was created as my first Unity game to learn the fundamentals of game development, including gameplay programming, UI management, audio integration, object spawning, and player interaction.

---

## 📖 Overview

UdanTastari is a casual click-based shooting game where players must destroy randomly spawning alien UFOs to earn points. The objective is to eliminate all targets and achieve the maximum score to win the game.

The project demonstrates core Unity concepts such as prefabs, singleton-based game management, UI systems, audio sources, and event-driven gameplay.

---

## 🎮 Gameplay

1. Launch the game and click the **Start** button.
2. Alien UFOs begin spawning at random positions.
3. Click on a UFO to destroy it.
4. Each successful hit increases the player's score.
5. Reach **30 points** to complete the game.
6. A victory screen appears when all targets are successfully destroyed.

---

## ✨ Features

* Space-themed gameplay
* Random target spawning system
* Score tracking and display
* Start menu interface
* Victory screen
* Background music
* UFO spawn sound effects
* Win sound effects
* Mouse-click interaction
* Simple and beginner-friendly code architecture

---

## 🛠️ Technologies Used

| Technology        | Purpose               |
| ----------------- | --------------------- |
| Unity 2022.3.37f1 | Game Engine           |
| C#                | Gameplay Programming  |
| Unity UI          | User Interface        |
| Audio Source      | Sound Effects & Music |

---

## 🎵 Audio

The game includes multiple audio elements to improve player feedback and immersion:

* **Background Music** played during gameplay
* **Game Start Interaction**
* **Alien/UFO Spawn Sound Effect**
* **Target Hit Feedback**
* **Victory Sound Effect**

---

## 📂 Project Structure

```text
Assets
│
├── Scenes
│   └── SampleScene
│
├── Scripts
│   ├── GameplayManager.cs
│   ├── ShipManager.cs
│   └── UIManager.cs
│
├── Prefabs
│   └── UFO Target
│
├── Audio
│   ├── alien.wav
│   ├── boom.wav
│   └── interstellar.wav
│
├── Sprites
│   ├── UFO
│   ├── Background
│   └── Crosshair
│
└── UI
```

---

## 🧩 Core Systems

### Gameplay Manager

Responsible for:

* Spawning UFO targets
* Managing score
* Tracking game progress
* Handling win conditions
* Controlling game state

### Ship Manager

Responsible for:

* Detecting player clicks
* Destroying targets
* Awarding points
* Triggering gameplay events

### UI Manager

Responsible for:

* Managing menu panels
* Handling Start button functionality
* Transitioning from menu to gameplay

---

## 📸 Screenshots

### Main Menu


<img width="1919" height="1079" alt="Screenshot 2026-06-05 151221" src="https://github.com/user-attachments/assets/cfd8b113-72a4-4d96-a05e-c44f6175fbbe" />


### Gameplay

<img width="1919" height="1079" alt="Screenshot 2026-06-05 152946" src="https://github.com/user-attachments/assets/bec7ec16-c44c-41ca-9426-6130e08e6b86" />


### Victory Screen

<img width="1919" height="1079" alt="Screenshot 2026-06-05 153101" src="https://github.com/user-attachments/assets/84d58a4a-012e-477a-b048-84d3a6ca8e53" />


## 🧠 Learning Outcomes

Through this project I learned:

* Unity Editor workflow
* Scene management
* Prefab creation and usage
* Randomized object spawning
* Singleton pattern implementation
* UI Canvas system
* Button events
* Audio integration
* Mouse input handling
* Basic game architecture
* Game state management

---

## 🚧 Future Improvements

Planned enhancements include:

* Multiple difficulty levels
* Countdown timer
* High score system
* Particle effects
* Animated UI transitions
* Sound settings menu
* Pause and restart functionality
* Mobile support
* Additional enemy types
* Progressive spawning mechanics

---

## ▶️ Getting Started

### Prerequisites

* Unity Hub
* Unity 2022.3.37f1 or later

### Installation

Clone the repository:

```bash
git clone https://github.com/your-username/UdanTastari.git
```

Open the project using Unity Hub and load:

```text
Assets/Scenes/SampleScene.unity
```

Press **Play** in the Unity Editor to start the game.

---

## 📚 Learning Resource

This project was developed while following and learning from the Unity tutorial below:

YouTube Tutorial:
https://www.youtube.com/watch?v=aOKNEMRKxng

---

## 👨‍💻 Author

**Rajan**

Aspiring Game Developer

This project marks the beginning of my journey into Unity and game development. It serves as a foundation for future projects and continued learning in gameplay programming, software architecture, and interactive experiences.

---

## 📄 License

This project is available for educational and personal learning purposes.
