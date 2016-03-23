var outHtml = (
<div>
    <ul className="breadcrumb">
    <li>
    <i className="fa-list-alt"></i>
        {this.props.menuName}
    </li>
    </ul>
    <h4 className="title"> {this.props.caption} 基本資料維護</h4>
    <form className="form-horizontal" onSubmit={this.handleSubmit}>
        <div className="col-xs-10">
        <div className="form-group">
        <label className="col-xs-2 control-label">標題</label>
        <div className="col-xs-8">
        <input type="text" className="form-control" onChange={this.changeFDValue.bind(this, 'name') } value={fieldData.name} maxLength={64}
               required />
        </div>
        <small className="col-xs-2 text-danger">(必填) </small>
        </div>

        <div className="form-action">
        <div className="col-xs-4 col-xs-offset-2">
        <button type="submit" className="btn-primary"><i className="fa-check"></i> 儲存</button>{}
        <button type="button" onClick={this.noneType}><i className="fa-times"></i> 回前頁</button>
        </div>
        </div>
        </div>
    </form>
</div>
);