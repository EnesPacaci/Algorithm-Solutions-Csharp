# HashMaps Algorithmic Solutions

This repository contains C# solutions for common algorithmic problems using Hash Maps.

---

## Two Sum

### Problem Statement
Find the indices of two numbers in an array that add up to a specific target value.

### Approach
Used a **Dictionary (Hash Map)** to store each number and its index as we iterate through the list. This allows us to check for the required "complement" number in $O(1)$ time, reducing the total time complexity to $O(N)$.

### Complexity Analysis
- **Time Complexity:** $O(N)$ — We traverse the list exactly once.
- **Space Complexity:** $O(N)$ — In the worst case, we store nearly all elements in the Dictionary.

### Key Learning
- Leveraging Hash Maps to transform an $O(N^2)$ brute-force search into an $O(N)$ linear-time solution.
- Using a dictionary to trade memory space for significant time efficiency.

---

## Top K Frequent Events

### Problem Statement
Given an array of integers `events` and an integer `k`, return the `k` most frequent elements. If two elements have the same frequency, prioritize the one that appears first in the original array (smallest starting index).

### Approach
Uses a **Dictionary (Hash Map)** combined with **Tuples** to store both frequency and the first appearance index. This allows us to track metadata in a single pass ($O(N)$). We then use **LINQ** for efficient sorting based on multiple criteria:
- **Primary Sort:** Frequency (Descending).
- **Secondary Sort:** First occurrence index (Ascending) for tie-breaking.

### Complexity Analysis
- **Time Complexity:** $O(N + M \log M)$, where $N$ is the array size and $M$ is the number of unique elements.
- **Space Complexity:** $O(M)$ to store unique elements and their stats in the Dictionary.

### Key Learning
- Using **Tuples** inside a Dictionary to store multiple pieces of metadata (frequency + index) for a single key.
- Leveraging **LINQ's `OrderByDescending` and `ThenBy`** for clean, multi-level sorting logic instead of complex nested loops.