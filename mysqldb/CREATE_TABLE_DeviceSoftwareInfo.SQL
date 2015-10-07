/****** 对象:  Table DeviceSoftwareInfo    脚本日期: 2015/9/30 16:49:11 ******/
/****** 字段数据长度 = 1170 字节 ******/
DROP TABLE IF EXISTS `DeviceSoftwareInfo`;
CREATE TABLE `DeviceSoftwareInfo`(
	`KeyID`                            varchar(28)          NOT NULL DEFAULT ''                    COMMENT '主键',
	`DeviceID`                         varchar(28)          NOT NULL DEFAULT ''                    COMMENT '设备ID',
	`SoftwareInfoName`                 varchar(64)          NOT NULL DEFAULT ''                    COMMENT '软件名称',
	`SoftwareInfoPath`                 varchar(256)         NOT NULL DEFAULT ''                    COMMENT '软件路径',
	`AddTime`                          datetime             NOT NULL DEFAULT '1900-01-01 00:00:00' COMMENT '添加时间',
	`ExecuteTime`                      datetime             NOT NULL DEFAULT '1900-01-01 00:00:00' COMMENT '执行时间',
	`ModifyTime`                       timestamp            NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间(CURRENT_TIMESTAMP)',
	`IsDelete`                         tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '是否删除:0-未删除 / 1-删除',
	PRIMARY KEY ( `KeyID` )
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='设备软件信息表:';
