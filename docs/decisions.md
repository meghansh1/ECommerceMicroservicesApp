# Architectural Decision Records

## ADR-001 Repository Pattern

Status: Accepted

Decision:

Use Repository Pattern between business layer and persistence layer.

Reason:

Allows switching persistence implementations without affecting business logic.

---

## ADR-002 Service Layer

Status: Accepted

Decision:

Controllers should communicate only with Services.

Reason:

Keeps business logic outside API layer.

---

## ADR-003 Database Per Service

Status: Accepted

Decision:

Each microservice owns its own database.

Reason:

Ensures service independence and loose coupling.

---

## ADR-004 Event Driven Communication

Status: Planned

Decision:

Services communicate asynchronously using RabbitMQ events.

Reason:

Improves scalability and reduces direct service dependencies.
