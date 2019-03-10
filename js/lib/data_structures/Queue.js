class Queue {
    constructor() {
        let _q = [];
        this.enqueue = (item) => _q.unshift(item);
        this.dequeue = () => _q.pop();
        this.isEmpty = () => _q.length === 0;
    }
}

module.exports = Queue;