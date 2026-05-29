## Validate Properly Nested Brackets

### Problem Statement
Given a string snippet, verify if all brackets (`()`, `{}`, `[]`) are properly matched and nested. Ignore all other characters. Return `true` if valid, otherwise `false`.

### Approach
Used a **Stack** data structure combined with a **Dictionary**:
1. **Rule Mapping:** A Dictionary maps closing brackets (Keys) to their corresponding opening brackets (Values) to avoid multiple `if-else` conditions.
2. **LIFO Tracking:** Iterated through the string. Pushed any opening bracket into the Stack.
3. **Validation & Popping:** Upon encountering a closing bracket, checked if the Stack was empty (invalid) or if the `Pop()` value from the Stack mismatched the expected opening bracket from the Dictionary (invalid).
4. **Final Check:** Returned `true` only if the Stack was completely empty (`Count == 0`) at the end of the loop, ensuring no unclosed brackets remained.

### Complexity Analysis
- **Time Complexity:** $O(N)$ — The string is traversed exactly once. `Push`, `Pop`, and Dictionary lookups all execute in $O(1)$ time.
- **Space Complexity:** $O(N)$ — In the worst-case scenario (e.g., a string consisting only of opening brackets `"((((("`), all characters will be stored in the Stack.

### Key Learning
- Understanding the crucial role of the Stack's **LIFO (Last In, First Out)** behavior in resolving nested structures.
- Returning the evaluation of a condition directly (e.g., `return stack.Count == 0;`) instead of using redundant `if (condition) return true; else return false;` blocks.