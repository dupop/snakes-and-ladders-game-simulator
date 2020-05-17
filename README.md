# Snakes and ladders board game simulator
Statistical analysis of a "Snakes &amp; ladders" board game


# Possible program output:
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
> Duration per player [min] (15s per move assumed): avg = 9, std dev = 6, min = 2, max = 25.
> Game will usually have 9 +- 6 (i.e. 3 - 15) duration per player [min] (15s per move assumed).
> 
> Jumps: avg = 9, std dev = 7, min = 1, max = 43.
> Game will usually have 9 +- 7 (i.e. 2 - 16) jumps.
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
> Player is on position 0. Dice gave result 2 on throwing number 1.
> Moved player by 2 to position 2
> Player jumped to position 4.            <-- IMPORTANT
> 
> Player is on position 4. Dice gave result 2 on throwing number 2.
> Moved player by 2 to position 6
> 
> Player is on position 6. Dice gave result 1 on throwing number 3.
> Moved player by 1 to position 7
> 
> Player is on position 7. Dice gave result 1 on throwing number 4.
> Moved player by 1 to position 8
> 
> Player is on position 8. Dice gave result 2 on throwing number 5.
> Moved player by 2 to position 10
> 
> Player is on position 10. Dice gave result 4 on throwing number 6.
> Moved player by 4 to position 14
> 
> Player is on position 14. Dice gave result 1 on throwing number 7.
> Moved player by 1 to position 15
> 
> Player is on position 15. Dice gave result 6 on throwing number 8.
> Moved player by 6 to position 21
> 
> Player is on position 21. Dice gave result 6 on throwing number 9.
> Moved player by 6 to position 27
> Player jumped to position 6.            <-- IMPORTANT
> 
> Player is on position 6. Dice gave result 5 on throwing number 10.
> Moved player by 5 to position 11
> 
> Player is on position 11. Dice gave result 6 on throwing number 11.
> Moved player by 6 to position 17
> 
> Player is on position 17. Dice gave result 1 on throwing number 12.
> Moved player by 1 to position 18
> Player jumped to position 75.           <-- IMPORTANT
> 
> Player is on position 75. Dice gave result 4 on throwing number 13.
> Moved player by 4 to position 79
> 
> Player is on position 79. Dice gave result 3 on throwing number 14.
> Moved player by 3 to position 82
> Player jumped to position 80.           <-- IMPORTANT
> 
> Player is on position 80. Dice gave result 2 on throwing number 15.
> Moved player by 2 to position 82
> Player jumped to position 80.           <-- IMPORTANT
> 
> Player is on position 80. Dice gave result 1 on throwing number 16.
> Moved player by 1 to position 81
> 
> Player is on position 81. Dice gave result 5 on throwing number 17.
> Moved player by 5 to position 86
> 
> Player is on position 86. Dice gave result 4 on throwing number 18.
> Moved player by 4 to position 90
> 
> Player is on position 90. Dice gave result 4 on throwing number 19.
> Moved player by 4 to position 94
> Player jumped to position 67.           <-- IMPORTANT
> 
> Player is on position 67. Dice gave result 1 on throwing number 20.
> Moved player by 1 to position 68
> 
> Player is on position 68. Dice gave result 6 on throwing number 21.
> Moved player by 6 to position 74
> 
> Player is on position 74. Dice gave result 5 on throwing number 22.
> Moved player by 5 to position 79
> 
> Player is on position 79. Dice gave result 1 on throwing number 23.
> Moved player by 1 to position 80
> 
> Player is on position 80. Dice gave result 2 on throwing number 24.
> Moved player by 2 to position 82
> Player jumped to position 80.           <-- IMPORTANT
> 
> Player is on position 80. Dice gave result 3 on throwing number 25.
> Moved player by 3 to position 83
> 
> Player is on position 83. Dice gave result 5 on throwing number 26.
> Moved player by 5 to position 88
> Player jumped to position 62.           <-- IMPORTANT
> 
> Player is on position 62. Dice gave result 3 on throwing number 27.
> Moved player by 3 to position 65
> 
> Player is on position 65. Dice gave result 1 on throwing number 28.
> Moved player by 1 to position 66
> 
> Player is on position 66. Dice gave result 6 on throwing number 29.
> Moved player by 6 to position 72
> Player jumped to position 98.           <-- IMPORTANT
> 
> Player is on position 98. Dice gave result 5 on throwing number 30.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 98. Dice gave result 1 on throwing number 31.
> Moved player by 1 to position 99
> 
> Player is on position 99. Dice gave result 5 on throwing number 32.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 2 on throwing number 33.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 2 on throwing number 34.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 3 on throwing number 35.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 5 on throwing number 36.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 2 on throwing number 37.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 4 on throwing number 38.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 3 on throwing number 39.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 4 on throwing number 40.
> Player can't move.                      <-- IMPORTANT
> 
> Player is on position 99. Dice gave result 1 on throwing number 41.
> Moved player by 1 to position 100
> Player won the game in 41 turns.
> 
> Last game statistics: Turns: 41, Jumps: 9, Times player was unable to move: 10
> 