# Payment System - Law of Demeter Refactoring

## Overview
This project demonstrates clean code practices using:
- Law of Demeter
- Tell, Don't Ask principle
- SOLID principles

## Key Idea
The Paperboy no longer accesses Wallet directly.
Instead, it tells the Customer to pay.

## Structure
- Entities → Business logic (Customer, Wallet)
- Interfaces → Abstractions (IPayable)
- Services → Use cases (Paperboy)

## Example
Paperboy → Customer.Pay(amount)

## Benefits
- Loose coupling
- Better encapsulation
- Clean architecture
