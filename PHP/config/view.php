<?php
/**
 * This file is part of webman.
 *
 * Licensed under The MIT License
 * For full copyright and license information, please see the MIT-LICENSE.txt
 * Redistributions of files must retain the above copyright notice.
 *
 * @author    walkor<walkor@workerman.net>
 * @copyright walkor<walkor@workerman.net>
 * @link      http://www.workerman.net/
 * @license   http://www.opensource.org/licenses/mit-license.php MIT License
 */

use support\view\Raw;
use support\view\Twig;
use support\view\Blade;
use support\view\ThinkPHP;

return [
    //'handler' => Raw::class,
    'handler' => ThinkPHP::class,
    'options' => [
        // 模板引擎普通标签开始标记
        'tpl_begin'     => '{',
        // 模板引擎普通标签结束标记
        'tpl_end'       => '}',
    ],
];
