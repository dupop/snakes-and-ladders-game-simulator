# snakes and ladders game simulator
Statistical analysis of a "Snakes &amp; ladders" board game


# Possible program output:
> # snakes-and-ladders-game-simulator
> Statistical analysis of a "Snakes &amp; ladders" board game
> 
> 
> Program output:
> 
> Number of snakes and ladders loaded: 24.
> 
> 
> Default simulation config:
> [DurationOfOneMoveInSeconds = 15, NumberOfIterations = 5000, NumberOfProgressLogs = 10, MaxTurns = 100].
> Press ENTER to begin or input custom comma separated values.
> 
> 
> 
> Running simulation with 5000 iterations:
> 
> Simulation progress: 0%
> Simulation progress: 10%
> Simulation progress: 20%
> Simulation progress: 30%
> Simulation progress: 40%
> Simulation progress: 50%
> Simulation progress: 60%
> Simulation progress: 70%
> Simulation progress: 80%
> Simulation progress: 90%
> Simulation done. Simulation actual duration: 0s
> 
> 
> Game statistical analysis:
> 
> Duration per player [min] (15s per move assumed): avg = 9, std dev = 5, min = 1, max = 25.
> Game will usually have 9 +- 5 (i.e. 3 - 14) duration per player [min] (15s per move assumed).
> 
> Jumps: avg = 8, std dev = 7, min = , max = 40.
> Game will usually have 8 +- 7 (i.e. 2 - 15) jumps.
> 
> 
> Statistical method and disclaimer:
> 
> * Caluclation done by using Monte Carlo analysis on 5000 game runs.
> * Probablity of human readable conclusions is 68% as one sigma is meant by "usually".
> * Effects of Monte Carlo uncertanity not taken into account in word "usually".
> 
> 
> Executing one game with live scores:
> 
> Player is on position 0. Dice gave result 3 on throwing number 1.
> Moved player by 3 to position 3
> 
> Player is on position 3. Dice gave result 2 on throwing number 2.
> Moved player by 2 to position 5
> 
> Player is on position 5. Dice gave result 3 on throwing number 3.
> Moved player by 3 to position 8
> 
> Player is on position 8. Dice gave result 2 on throwing number 4.
> Moved player by 2 to position 10
> 
> Player is on position 10. Dice gave result 4 on throwing number 5.
> Moved player by 4 to position 14
> 
> Player is on position 14. Dice gave result 1 on throwing number 6.
> Moved player by 1 to position 15
> 
> Player is on position 15. Dice gave result 4 on throwing number 7.
> Moved player by 4 to position 19
> 
> Player is on position 19. Dice gave result 4 on throwing number 8.
> Moved player by 4 to position 23
> Player jumped to position 66.           <-- IMPORTANT
> 
> Player is on position 66. Dice gave result 4 on throwing number 9.
> Moved player by 4 to position 70
> 
> Player is on position 70. Dice gave result 1 on throwing number 10.
> Moved player by 1 to position 71
> 
> Player is on position 71. Dice gave result 5 on throwing number 11.
> Moved player by 5 to position 76
> 
> Player is on position 76. Dice gave result 4 on throwing number 12.
> Moved player by 4 to position 80
> 
> Player is on position 80. Dice gave result 5 on throwing number 13.
> Moved player by 5 to position 85
> 
> Player is on position 85. Dice gave result 6 on throwing number 14.
> Moved player by 6 to position 91
> Player jumped to position 32.           <-- IMPORTANT
> 
> Player is on position 32. Dice gave result 3 on throwing number 15.
> Moved player by 3 to position 35
> Player jumped to position 37.           <-- IMPORTANT
> 
> Player is on position 37. Dice gave result 3 on throwing number 16.
> Moved player by 3 to position 40
> Player jumped to position 30.           <-- IMPORTANT
> 
> Player is on position 30. Dice gave result 3 on throwing number 17.
> Moved player by 3 to position 33
> 
> Player is on position 33. Dice gave result 2 on throwing number 18.
> Moved player by 2 to position 35
> Player jumped to position 37.           <-- IMPORTANT
> 
> Player is on position 37. Dice gave result 4 on throwing number 19.
> Moved player by 4 to position 41
> Player jumped to position 20.           <-- IMPORTANT
> 
> Player is on position 20. Dice gave result 2 on throwing number 20.
> Moved player by 2 to position 22
> 
> Player is on position 22. Dice gave result 6 on throwing number 21.
> Moved player by 6 to position 28
> 
> Player is on position 28. Dice gave result 5 on throwing number 22.
> Moved player by 5 to position 33
> 
> Player is on position 33. Dice gave result 6 on throwing number 23.
> Moved player by 6 to position 39
> 
> Player is on position 39. Dice gave result 4 on throwing number 24.
> Moved player by 4 to position 43
> Player jumped to position 58.           <-- IMPORTANT
> 
> Player is on position 58. Dice gave result 1 on throwing number 25.
> Moved player by 1 to position 59
> 
> Player is on position 59. Dice gave result 3 on throwing number 26.
> Moved player by 3 to position 62
> 
> Player is on position 62. Dice gave result 2 on throwing number 27.
> Moved player by 2 to position 64
> 
> Player is on position 64. Dice gave result 3 on throwing number 28.
> Moved player by 3 to position 67
> 
> Player is on position 67. Dice gave result 5 on throwing number 29.
> Moved player by 5 to position 72
> Player jumped to position 98.           <-- IMPORTANT
> 
> Player is on position 98. Dice gave result 4 on throwing number 30.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 98. Dice gave result 6 on throwing number 31.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 98. Dice gave result 5 on throwing number 32.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 98. Dice gave result 2 on throwing number 33.
> Moved player by 2 to position 100
> Player won the game in 33 turns.
> 
> Last game statistics: Turns: 33, Jumps: 8, Times player was unable to move: 3
> 
