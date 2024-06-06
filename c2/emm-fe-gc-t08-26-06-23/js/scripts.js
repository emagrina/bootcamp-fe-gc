'use strict';

window.onload = () => {
  let currentInput = '0';
  let operation = null;
  let previousInput = null;

  const updateInputDisplay = (value) => {
    const display = document.getElementsByClassName('form-control')[0];
    display.value = value;
  };

  const updateResultDisplay = (value) => {
    const display = document.getElementsByClassName('input-group-text')[0];
    display.textContent = value;
  };

  const performOperation = (a, b, op) => {
    a = parseFloat(a);
    b = parseFloat(b);
    switch (op) {
      case '+':
        return a + b;
      case '-':
        return a - b;
      case '*':
        return a * b;
      default:
        return b;
    }
  };

  Array.from(document.getElementsByClassName('btn-outline-dark')).forEach(
    (button) => {
      button.addEventListener('click', (e) => {
        currentInput =
          currentInput === '0'
            ? e.target.innerText
            : currentInput + e.target.innerText;
        updateInputDisplay(currentInput);
      });
    }
  );

  Array.from(document.getElementsByClassName('btn-success')).forEach(
    (button) => {
      button.addEventListener('click', (e) => {
        switch (e.target.innerText) {
          case '+':
          case '-':
          case '*':
            if (currentInput !== '0') {
              operation = e.target.innerText;
              previousInput = currentInput;
              currentInput = '0';
            }
            break;
          case '.':
            if (!currentInput.includes('.')) {
              currentInput += '.';
            }
            break;
          case 'C':
            currentInput = '0';
            operation = null;
            previousInput = null;
            break;
          case '=':
            if (previousInput && operation) {
              currentInput = performOperation(
                previousInput,
                currentInput,
                operation
              );
              operation = null;
              previousInput = null;
              updateResultDisplay(currentInput);
              currentInput = '0';
            }
            break;
        }
        updateInputDisplay(currentInput);
      });
    }
  );
};
