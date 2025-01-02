# F# Mutable Variable Bug

This repository demonstrates a subtle bug related to the use of mutable variables within inline functions in F#. The bug arises from the interaction between mutable state and the inlining process.

The `bug.fs` file contains code that reproduces the unexpected behavior. The `bugSolution.fs` file provides a corrected version.

## Bug Description

The issue stems from the fact that when an inline function modifies a mutable variable passed by reference, the changes persist outside the scope of the inline function. This can lead to unforeseen side effects and make debugging challenging. 

## Solution

The solution involves using techniques such as creating copies of mutable variables within the inline function to prevent unintended modifications to the original variables. Alternatively, using immutable data structures and functional programming techniques to avoid mutable variables entirely. 