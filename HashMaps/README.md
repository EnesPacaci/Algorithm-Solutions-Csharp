# Two Sum - Algorithmic Solution

## Problem Statement
Find the indices of two numbers in an array that add up to a specific target value.

## Approach
Used a **Dictionary (Hash Map)** to store each number and its index as we iterate through the list. This allows us to check for the required "complement" number in $O(1)$ time, reducing the total time complexity to $O(N)$.

## Complexity Analysis
- **Time Complexity:** $O(N)$ — We traverse the list exactly once.
- **Space Complexity:** $O(N)$ — In the worst case, we store nearly all elements in the Dictionary.

## Key Learning
- Leveraging Hash Maps to transform an $O(N^2)$ brute-force search into an $O(N)$ linear-time solution.
- Using a dictionary to trade memory space for significant time efficiency.