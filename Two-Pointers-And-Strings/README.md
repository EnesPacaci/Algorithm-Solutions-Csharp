# Two Pointers and Strings Algorithmic Solutions

This repository contains C# solutions for common string manipulation and two-pointer algorithmic problems.

---

## Check Palindrome by Filtering Non-Letters

### Problem Statement
Given a string containing letters, digits, and symbols, determine if it reads the same forwards and backwards when considering only alphabetic characters (case-insensitive).

### Approach
Used a two-step process:
1. **Cleaning:** Iterated through the string using `char.IsLetter` and appended lowercase versions of valid characters to a **`StringBuilder`**.
2. **Validation:** Used the **Two Pointers** technique (`left` at index 0, `right` at the last index) moving towards the center to verify if the cleaned string is a palindrome. 

### Complexity Analysis
- **Time Complexity:** $O(N)$ — We traverse the string twice (once for cleaning, once for checking), which simplifies to $O(N)$.
- **Space Complexity:** $O(N)$ — We store the cleaned alphabetic characters in a new `StringBuilder` object.

### Key Learning
- Understanding the performance difference between `string` (Immutable, $O(N^2)$ for concatenation) and `StringBuilder` (Mutable, $O(N)$) in C#.
- Applying the **Two Pointers** technique with a `while (left < right)` loop for optimal, early-exit condition checking.