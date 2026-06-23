# E-Commerce Microservices Platform

A production-grade E-Commerce platform built using .NET 10 and Microservices Architecture.

## Objective

The goal of this project is to demonstrate enterprise software engineering practices including:

* Microservices Architecture
* Domain Driven Design Concepts
* Repository Pattern
* Dependency Injection
* API Gateway
* Event Driven Architecture
* RabbitMQ Messaging
* SQL Server
* Docker
* CI/CD Pipelines
* JWT Authentication
* Observability and Logging

---

## Technology Stack

### Backend

* .NET 10
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server

### Messaging

* RabbitMQ

### API Gateway

* YARP Reverse Proxy

### Logging

* Serilog
* Seq

### DevOps

* Docker
* Docker Compose
* GitHub Actions

---

## Planned Services

### Product Service

Responsible for:

* Product Catalog
* Product Search
* Product Management

### Order Service

Responsible for:

* Order Creation
* Order Tracking
* Order Status

### Inventory Service

Responsible for:

* Inventory Management
* Stock Reservation

### Notification Service

Responsible for:

* Email Notifications
* Order Notifications

---

## Repository Structure

src/

* ProductService
* OrderService
* InventoryService
* NotificationService
* Gateway

building-blocks/

* SharedKernel
* Contracts
* EventBus

tests/

docs/

---

## Current Status

Phase 1 - Product Service

* [x] Solution Setup
* [x] Product Entity
* [x] Repository Layer
* [x] Service Layer
* [x] In-Memory CRUD

Upcoming:

* [ ] EF Core
* [ ] SQL Server
* [ ] Order Service
* [ ] RabbitMQ
* [ ] Inventory Service
* [ ] Docker

---

## Architecture

Refer:

docs/architecture.md

