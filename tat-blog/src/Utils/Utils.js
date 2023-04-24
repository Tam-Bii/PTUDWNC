export function isEmptyOrderSpaces (str) {
    return str === null || (typeof str === 'string' && str.match(/^ *$/) !== null);
}