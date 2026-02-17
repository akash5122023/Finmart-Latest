namespace AdvanceCRM {

    @Serenity.Decorators.registerEditor()
    export class LoanAmountEditor extends Serenity.Widget<any> implements Serenity.IStringValue {

        constructor(input: JQuery) {
            super(input);

            input.select2({
                allowClear: true,
                placeholder: 'Select or enter amount',
                data: [
                    { id: '5000000', text: '₹ 50,00,000 (50 Lakhs)' },
                    { id: '7500000', text: '₹ 75,00,000 (75 Lakhs)' },
                    { id: '10000000', text: '₹ 1,00,00,000 (1 Crore)' },
                    { id: '10050000', text: '₹ 1,00,50,000 (1 Crore 50 Thousand)' },
                    { id: '17500000', text: '₹ 1,75,00,000 (1 Crore 75 Lakhs)' }
                ],
                createSearchChoice: (term: string) => {
                    var num = parseFloat(term.replace(/[₹,\s]/g, ''));
                    if (!isNaN(num) && num > 0) {
                        return {
                            id: num.toString(),
                            text: '₹ ' + this.formatIndianCurrency(num)
                        };
                    }
                    return null;
                },
                formatSelection: (item: any) => {
                    if (item.text) {
                        return item.text;
                    }
                    var num = parseFloat(item.id);
                    if (!isNaN(num)) {
                        return '₹ ' + this.formatIndianCurrency(num);
                    }
                    return item.id;
                },
                formatResult: (item: any) => {
                    return item.text || item.id;
                }
            });
        }

        public get_value(): string {
            return this.element.val() as string;
        }

        public set_value(value: string): void {
            if (value == null || value === '') {
                this.element.select2('val', '');
            } else {
                this.element.select2('val', value);
            }
        }

        private formatIndianCurrency(num: number): string {
            var str = num.toString();
            var lastThree = str.substring(str.length - 3);
            var otherNumbers = str.substring(0, str.length - 3);
            if (otherNumbers != '')
                lastThree = ',' + lastThree;
            return otherNumbers.replace(/\B(?=(\d{2})+(?!\d))/g, ",") + lastThree;
        }
    }
}