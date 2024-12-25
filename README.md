# Unexpected Behavior with Mutable Variables in F# Functions

This repository demonstrates a common issue encountered when working with mutable variables in F# functions.  The code showcases how modifying mutable variables within a function can lead to unexpected results if not managed properly.  The solution file provides a corrected approach to handle mutable variables to achieve the desired outcome.

## Problem

The `bug.fs` file contains F# code that uses mutable variables within functions. Observe the discrepancy between the expected output and the actual output when modifying mutable variables directly vs. using local copies.