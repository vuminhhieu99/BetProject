﻿using Bet.Common.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet.Common.Entities.BO
{
    [TableName("bet_real_time")]
    public class BetRealTime : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Thời gian trên sân
        /// </summary>
        [Column]
        public int TimeReal { get; set; }
        /// <summary>
        /// Thuộc trận đấu
        /// </summary>
        [Column]
        public int MatchId { get; set; }
        /// <summary>
        /// idkèo trên
        /// </summary>        
        [Column]
        public int AboveId { get; set; }
        /// <summary>
        /// Tên kèo trên
        /// </summary>        
        [Column]
        public string? AboveName { get; set; }
        /// <summary>
        /// Kèo dưới 
        /// </summary>        
        [Column]
        public int BelowId { get; set; }
        /// <summary>
        /// Tên kèo dưới 
        /// </summary> 
        [Column]
        public string? BelowName { get; set; }
        /// <summary>
        /// kèo trên là chủ nhà
        /// </summary> 
        [Column]
        public bool IsAboveHost { get; set; }
        /// <summary>
        /// Tỷ số kèo trên
        /// </summary> 
        [Column]
        public int AboveScore { get; set; }
        /// <summary>
        /// Tỷ số kèo dưới
        /// </summary> 
        [Column]
        public int BelowScore { get; set; }
        /// <summary>
        /// Số phạt góc kèo trên
        /// </summary> 
        [Column]
        public int AboveCorner { get; set; }
        /// <summary>
        /// Số phạt góc kèo dưới
        /// </summary> 
        [Column]
        public int BelowCorner { get; set; }
        /// <summary>
        /// Số Penalty kèo trên
        /// </summary> 
        [Column]
        public int AbovePenalty { get; set; }
        /// <summary>
        /// Số Penalty kèo dưới
        /// </summary> 
        [Column]
        public int BelowPenalty { get; set; }
        /// <summary>
        /// Số thẻ vàng kèo trên
        /// </summary> 
        [Column]
        public int AboveYellowCard { get; set; }
        /// <summary>
        /// Số thẻ đỏ kèo trên
        /// </summary> 
        [Column]
        public int AboveRedCard { get; set; }
        /// <summary>
        /// Số thẻ vàng kèo dưới
        /// </summary> 
        [Column]
        public int BelowYellowCard { get; set; }
        /// <summary>
        /// Số thẻ đỏ kèo dưới
        /// </summary> 
        [Column]
        public int BelowRedCard { get; set; }
        /// <summary>
        /// Số Tỉ giá kèo trên thắng
        /// </summary> 
        [Column]
        public float AboveWinRatio { get; set; }
        /// <summary>
        /// Tỉ giá kèo dưới thắng
        /// </summary> 
        [Column]
        public float BelowWinRatio { get; set; }
        /// <summary>
        /// Tỉ giá tỷ số hòa
        /// </summary> 
        [Column]
        public float DrawRatio { get; set; }
          
    }
}
