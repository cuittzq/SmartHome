/****** 对象:  Table DeviceTaskInfo    脚本日期: 2015/9/30 16:49:11 ******/
/****** 字段数据长度 = 1754 字节 ******/
DROP TABLE IF EXISTS `DeviceTaskInfo`;
CREATE TABLE `DeviceTaskInfo`(
	`KeyID`                            varchar(28)          NOT NULL DEFAULT ''                    COMMENT '任务ID',
	`DeviceID`                         varchar(28)          NOT NULL DEFAULT ''                    COMMENT '设备ID',
	`TaskType`                         tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '任务类型',
	`CommandCode`                      varchar(512)         NOT NULL DEFAULT ''                    COMMENT '命名代码',
	`CommandScript`                    text                 NOT NULL DEFAULT ''                    COMMENT '命令脚本',
	`TaskStatus`                       tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '任务状态',
	`TaskResult`                       text                 NOT NULL DEFAULT ''                    COMMENT '任务反馈',
	`AddTime`                          datetime             NOT NULL DEFAULT '1900-01-01 00:00:00' COMMENT '添加时间',
	`ExecuteTime`                      datetime             NOT NULL DEFAULT '1900-01-01 00:00:00' COMMENT '执行时间',
	`ModifyTime`                       timestamp            NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间(CURRENT_TIMESTAMP)',
	`IsDelete`                         tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '是否删除:0-未删除 / 1-删除',
	PRIMARY KEY ( `KeyID` )
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='设备任务表:';
