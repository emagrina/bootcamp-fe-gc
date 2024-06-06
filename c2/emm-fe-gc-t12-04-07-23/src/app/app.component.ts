import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'emm-fe-gc-t12-04-07-23';

  currentInput: string = '0';
  operation: string | null = null;
  previousInput: string | null = null;
  result: string = '';

  updateInputDisplay(value: string) {
    this.currentInput = value;
  }

  updateResultDisplay(value: string) {
    this.result = value;
  }

  /**
   * Haremos los calculos necesarios +,-,*,/
   * @param a
   * @param b
   * @param op
   * @returns {number}
   */
  performOperation(a: number, b: number, op: string): number {
    switch (op) {
      case '+':
        return a + b;
      case '-':
        return a - b;
      case 'x':
        return a * b;
      case '÷':
        return a / b;
      default:
        return b;
    }
  }

  /**
   * Insertar los valores a calcular
   * @param number
   */
  handleNumberClick(number: string) {
    this.currentInput =
      this.currentInput === '0' ? number : this.currentInput + number;
    this.updateInputDisplay(this.currentInput);
  }

  /**
   * Mediante la operacion que le digamos qe nos haga mostraremos una cosa o otra.
   * @param op
   */
  handleOperationClick(op: string) {
    switch (op) {
      case '+':
      case '-':
      case 'x':
      case '÷':
        if (this.currentInput !== '0') {
          this.operation = op;
          this.previousInput = this.currentInput;
          this.currentInput = '0';
        }
        break;
      case '.':
        if (!this.currentInput.includes('.')) {
          this.currentInput += '.';
        }
        break;
      case 'C':
        this.currentInput = '0';
        this.operation = null;
        this.previousInput = null;
        this.updateResultDisplay('');
        break;
      case '±':
        if (this.currentInput !== '0') {
          this.currentInput = (-parseFloat(this.currentInput)).toString();
        }
        break;
      case '%':
        if (this.currentInput !== '0') {
          const inputValue = parseFloat(this.currentInput);
          const percentage = inputValue / 100;
          this.currentInput = percentage.toString();
        }
        break;

      case '=':
        if (this.previousInput && this.operation) {
          const result = this.performOperation(
            parseFloat(this.previousInput),
            parseFloat(this.currentInput),
            this.operation
          );
          this.updateResultDisplay(result.toFixed(2));

          this.currentInput = '0';
          this.operation = null;
          this.previousInput = null;
        }
        break;
    }
    this.updateInputDisplay(this.currentInput);
  }

  /**
   * Ira variando si mostrar el input o mostrar el resultado si pulsamos el igual
   * @returns this.result
   */
  getResultDisplay(): string {
    return this.result !== '' ? this.result : this.currentInput;
  }
}
