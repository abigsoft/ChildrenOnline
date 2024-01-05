<?php

namespace app\queue\redis;

use Webman\RedisQueue\Consumer;

class WordMessage implements Consumer
{
    // 要消费的队列名
    public $queue = 'word-message';
    // 消费
    public function consume($data)
    {
        // 无需反序列化
        var_export($data);
    }
}