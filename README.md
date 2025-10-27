# Task 3: Complete Patterns Integration

# Project Evolution
# Task 2 Foundation
- Singleton Pattern: GameManager, AudioManager
- Basic game with centralized management

## Task 3 Additions
## Observer Pattern
- EventManager for decoupled communication
## - Events implemented:
("OnScoreChanged", UpdateScore)
 ("OnPlayerStateChanged", UpdateStateDisplay)
 ("OnGameOver", ShowGameOver)
 ("OnLevelComplete", ShowVictory)
("OnCoinCollected", UpdateCoinCount)
("OnPlayerDeath", ShowDeath)
- Observers - UI Manager and Achievements

## State Machine Pattern
- Player States: Idle, Run, Jump
- Game States: Enhanced from Task 2
- State transitions: Idle to move: D and A, Run to jump: Space Fire: F

### Key Integration Points
1. Score System: Singleton → Observer → UI
2. Player Actions: Input → State → Event → Audio
3. Game Flow: GameState: Time limit and One Scene

## Repository Statistics
- Total Commits: 19
- Task 3 Commits: 19
- Lines of Code: Game Manager: 178
- Development Time: 7 hours

## How to Play
- Controls: WASD and Space, and F 
- Objective: Go through an obstacle course to reach the goal before the timer ends. You have to go through the whole thing in one go without Dying
- New Features: New level design, rougle-like
