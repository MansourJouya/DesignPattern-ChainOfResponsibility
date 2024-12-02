# Design Patterns - Chain of Responsibility

This repository showcases an implementation of the Chain of Responsibility design pattern in C#. The code demonstrates how to pass a request through a chain of handlers, where each handler can process the request or pass it along, creating a flexible and scalable way to handle various types of requests.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Chain of Responsibility design pattern is a behavioral pattern that allows an object to pass a request along a chain of potential handlers until one of them handles the request. This decouples the sender of the request from its receivers, promoting a flexible chain structure that can handle multiple types of requests.

## Implementation Overview
This repository provides a C# implementation of the Chain of Responsibility pattern. Key components of the code include:

- **Handler Class**: An abstract class that defines the interface for handling requests and chaining handlers.
- **Step1Handler, Step2Handler, Step3Handler Classes**: Concrete implementations that handle specific types of requests.
- **Program Class**: Demonstrates how to create and chain handlers and process requests.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-ChainOfResponsibility.git
```

Navigate into the project directory:

```bash
cd DesignPattern-ChainOfResponsibility
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Chain of Responsibility pattern in action.
3. Modify or extend the `Handler`, `Step1Handler`, `Step2Handler`, or `Step3Handler` classes to simulate different scenarios.

### Example Output:
```
Processing Step1 request:
Step 1 Handler: Processing request.

Processing Step2 request:
Step 2 Handler: Processing request.

Processing Step3 request:
Step 3 Handler: Processing request.

Processing unknown request:
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.
