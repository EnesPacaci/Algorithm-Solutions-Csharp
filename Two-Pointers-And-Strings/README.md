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


## Max Unique Substring Length in a Session

### Problem Statement
Given a string of lowercase letters with sessions separated by `'*'` characters, find the maximum length of a substring with all distinct letters within any single session. If the string is empty or contains only `'*'`, return `0`.

### Approach
Used the **Sliding Window** technique combined with a **Dictionary (Hash Map)**:
1. **Guard Clause:** Used `string.IsNullOrEmpty` and LINQ `All()` to instantly filter out edge cases.
2. **Session Reset:** Cleared the dictionary and advanced the `left` pointer whenever a `'*'` boundary was encountered.
3. **Collision Detection:** Tracked the latest index of each character in the Dictionary. When a duplicate character was found inside the current window boundary (`index >= left`), the `left` pointer was smoothly shifted to `duplicate_index + 1`.
4. **Max Calculation:** Continuously evaluated `Math.Max(maxLength, right - left + 1)` for non-star characters.

### Complexity Analysis
- **Time Complexity:** $O(N)$ — We traverse the string exactly once. Dictionary lookups and insertions operate in $O(1)$ time.
- **Space Complexity:** $O(K)$ — Where $K$ is the number of unique characters in the alphabet (e.g., 26 for lowercase English letters). In the worst-case scenario, the Dictionary stores at most 26 key-value pairs, which resolves to $O(1)$ auxiliary space.

### Key Learning
- Mastering the `right - left + 1` logic to accurately calculate window sizes based on raw indexes.
- Understanding how to smoothly combine a fast-moving pointer (`right`) with a conditional-jumping pointer (`left`) to optimize $O(N^2)$ brute-force searches into a linear $O(N)$ pass.