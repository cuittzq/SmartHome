/****** 对象:  Table DeviceInfo    脚本日期: 2015/9/30 16:49:11 ******/
/****** 字段数据长度 = 288 字节 ******/
DROP TABLE IF EXISTS `DeviceInfo`;
CREATE TABLE `DeviceInfo`(
	`KeyID`                            varchar(28)          NOT NULL DEFAULT ''                    COMMENT '设备ID',
	`DeviceName`                       varchar(64)          NOT NULL DEFAULT ''                    COMMENT '设备名称',
	`DeviceType`                       tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '设备类型',
	`DeviceStatus`                     tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '设备状态',
	`ModifyTime`                       timestamp            NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间(CURRENT_TIMESTAMP)',
	`IsDelete`                         tinyint(4) unsigned  NOT NULL DEFAULT 0                     COMMENT '是否删除:0-未删除 / 1-删除',
	PRIMARY KEY ( `KeyID` )
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='设备基础信息表:';
